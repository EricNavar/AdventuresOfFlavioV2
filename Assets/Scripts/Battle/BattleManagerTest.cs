using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleManagerTest : MonoBehaviour
{
    private GameObject thePlayer;
    private string previousScene;
    private Vector3 previousLocation;
    private int turn;
    public Enemy[] enemies;
    private InventoryItem[] loot;
    private int totalExp;
    public Party theParty;
    private MonsterDex dex;
    private bool canEscape;
    private BattleUI UI;
    private bool gameOver = false;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        previousScene = SceneManager.GetActiveScene().name;

        //dex = FindObjectOfType<MonsterDex>();

        thePlayer = FindObjectOfType<PlayerController>().gameObject;
        thePlayer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        thePlayer.GetComponent<PlayerController>().canMove = false;
        previousLocation = thePlayer.transform.position;
        thePlayer.transform.position = new Vector2(5, -9);

        //Find the center of the screen then place the enemies around there
        Camera theCamera = FindObjectOfType<Camera>();
        float halfHeight = theCamera.orthographicSize;
        float halfWidth = halfHeight * Screen.width / Screen.height;

        theParty = FindObjectOfType<Party>();
        UI.SetParty(theParty);

        turn = 1;

        /*  
        float position = (enemies.Length - 1) / -2.0f;
        int offset = 100; // There will be 100 pixels between the anchor of each enemy.
        make enemies a radnom length from 1 to 3 and fill it with the same type of enemy as the one encountered
        GameObject enemyListGO = new GameObject("Enemies");
        enemyListGO.transform.parent = gameObject.transform;

        int enemyCount = UnityEngine.Random.Range(1, 3);
        enemies = new EnemyStats[enemyCount];
        for (int i = 0; i < enemies.Length; i++)
        {
            GameObject enemyGO = new GameObject("enemy" + i.ToString());
            enemyGO.transform.parent = enemyListGO.transform;
            enemies[i] = new GameObject().AddComponent<EnemyStats>();
        }
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i] = gameObject.AddComponent(typeof(EnemyStats)) as EnemyStats;
            enemies[i].gameObject.AddComponent<SpriteRenderer>();
            enemies[i].gameObject.transform.position = new Vector3(halfWidth + (position * offset), halfHeight, 0);
            position++;
        }

        foreach (EnemyStats enemy in enemies) //adds enemy into monsterdex
        {
            if (!dex.HaveSeen(enemy))
            {
                dex.Add(enemy);
            }
        }
        */
        Debug.Log("finished start()");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            BattleEnd("victory");
        }
    }

    private void BattleLoop()
    {
        Debug.Log("Starting Battle Loop");
        if (theParty == null)
        {
            theParty = FindObjectOfType<Party>();
            UI.SetParty(theParty);
        }

        if (!IsBattleOver())
        {
            foreach (Hero member in theParty.GetMembers())
            {
                UI.moveChooser.enabled = true;
                UI.list.UpdateOptions(member.GetMoveSet(), member.GetStats().GetCurrentStat(1));
                UI.battleText.text = "What will " + member.GetName() + " do?";
                while (!UI.moveChooser.flag)
                {

                }
            }

            foreach (Enemy enemy in enemies)
            {
                enemy.DecideAttack();
            }

            BattleInfo[] attackOrder = GetAttackOrder(theParty.GetMembers(), enemies);

            //Fix this entire foreach loop and every method in it.
            //Each combatant will attack. If it kills someone, it checks if the battle should end
            bool loop = true;
            foreach (BattleInfo combatant in attackOrder)
            {
                if (combatant.GetStats().GetCurrentStat(0) > 0)
                {
                    UI.battleText.text = combatant.GetName() + "uses" + combatant.GetNextMove().moveName;
                    combatant.Attack();

                    while (loop)
                    {
                        if (Input.GetKeyDown(KeyCode.J))
                        {
                            loop = false;
                        }
                    }

                    if (IsBattleOver())
                    {
                        //This breaks the loop if true;
                        turn++;
                    }
                }
            }//end foreach
        }//end if
    }

    //combatants is a list of the party and enemies in the battle
    private BattleInfo[] GetAttackOrder(Hero[] partyMembers, Enemy[] enemies) 
    {
        BattleInfo[] sortedList = new BattleInfo[enemies.Length + partyMembers.Length];
        Array.Copy(enemies, sortedList, enemies.Length);
        Array.Copy(theParty.GetMembers(), 0, sortedList, enemies.Length, theParty.GetMembers().Length);
        //copying arrays
        //https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=netframework-4.7.2#System_Array_Copy_System_Array_System_Int32_System_Array_System_Int32_System_Int32_

        //sort by priority, then by speed
        IEnumerable<BattleInfo> query = from combatant in sortedList
                                        orderby combatant.GetNextMove().priority, combatant.GetStats().GetCurrentStat(5)
                                        select combatant;
        return query.Cast<BattleInfo>().ToArray();

        //https://stackoverflow.com/questions/7099741/c-sharp-list-sort-by-two-columns
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/sorting-data
    }

    private void BattleEnd(string outcome)
    {
        if (outcome == "victory")
        {
            UI.battleText.text = "You defeated the enemies!";
            //Calculate exp
            int liveHeroes = 0;
            foreach (Hero hero in theParty.GetMembers())
            {
                hero.RevertBattleInfo();
                if (hero.GetStatus() != "dead")
                {
                    liveHeroes += 1;
                }
            }
            int expGiven = totalExp / liveHeroes; // how much xp each hero 
            SceneManager.LoadScene(previousScene);

            SceneManager.LoadScene(previousScene);//added
            PlayerController thePlayer = FindObjectOfType<PlayerController>();//added
            thePlayer.enabled = true;//added
            thePlayer.gameObject.transform.position = previousLocation;//addded

            //ShowVictoryScreen(expGiven, loot);
        }
        else if (outcome == "loss")
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.RevertBattleInfo();
            }
            theParty.ChangeMoney(-100);

            UI.battleText.text = "Your Team has fallen...";

            bool loop = true;
            while (loop)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    loop = false;
                }
            }

        }

        else //outcome = "ran away"
        {
            UI.battleText.text = "You ran away!";
            bool loop = true;
            while (loop)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    loop = false;
                }
            }

        }//end if else chain

        Destroy(gameObject);


    }

    private bool IsBattleOver()
    {
        bool allEnemiesDead = true;
        foreach (Enemy enemy in enemies)
        {
            if (enemy.GetStats().GetCurrentStat(0) > 0)
            {
                allEnemiesDead = false;
                break;
            }
        }

        bool allPlayersDead = true;
        foreach (Hero player in theParty.GetMembers())
        {
            if (player.GetStats().GetCurrentStat(0) > 0)
            {
                allPlayersDead = false;
                break;
            }
        }

        if (allPlayersDead)
        {
            BattleEnd("loss");
            return true;
        }

        else if (allEnemiesDead)
        {
            BattleEnd("victory");
            return true;
        }

        return false;
    }

    public InventoryItem[] GetInventory()
    {
        return loot;
    }

}