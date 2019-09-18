using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    private string previousScene;
    private Vector2 previousLocation;
    private int turn;
    public Enemy[] enemies;
    private InventoryItem[] loot;
    private int totalExp;
    public Party theParty;
    private MonsterDex dex;
    public bool canEscape;
    private ChooseMove ChooseMoveUI;
    public Text battleText;

    /*
     *         int enemyCount = 3;
        double[] arr = new double[enemyCount];
        double position = (double)(enemyCount - 1) / -2.0;
        int space = 100;//each enemy will be 100 pixels apart on the screen
        
        for (int i = 0; i < enemyCount; i++)
        {
            arr[i] = position * space;
            position++;
            System.out.println(arr[i]);
        }
        System.out.println("hello");
        */


    public BattleManager(Vector3 location, Enemy enemy)
    {
        previousLocation = location;
        Type enemyType = enemy.GetType();
        previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("battle");
        int enemyCount = UnityEngine.Random.Range(1,3);
        enemies = new Enemy[enemyCount];

        //Find the center of the screen then place the enemies around there
        Camera theCamera = FindObjectOfType<Camera>();
        float halfHeight = theCamera.orthographicSize;
        float halfWidth = halfHeight * Screen.width / Screen.height;

        float position = (enemyCount - 1) / -2.0f;
        int offset = 100; // There will be 100 pixels between the anchor of each enemy.

        for (int i = 0; i < enemyCount; i++)
        {
            enemies[i] = (Enemy)Activator.CreateInstance(enemyType);
            enemies[i].gameObject.transform.position = new Vector3(halfWidth + (position * offset), halfHeight, 0);
            position++;
        }
    }

    void Start()
    {
        FindObjectOfType<PlayerController>().enabled = false;
        theParty = FindObjectOfType<Party>();
        turn = 1;
        dex = FindObjectOfType<MonsterDex>();
        ChooseMoveUI = FindObjectOfType<ChooseMove>();
        

        foreach (Enemy enemy in enemies) //adds enemy into monsterdex
        {
            if (!dex.HaveSeen(enemy))
            {
                dex.Add(enemy);
            }
        }

        BattleLoop();
    }

    private void BattleLoop()
    {
        foreach (Hero member in theParty.GetMembers())
        {
            //ChooseMoveUI.Choose();
        }

        foreach (Enemy enemy in enemies)
        {
            enemy.DecideAttack();
        }

        BattleInfo[] attackOrder = new BattleInfo[enemies.Length + theParty.GetMembers().Length];
        Array.Copy(enemies, attackOrder, enemies.Length);
        Array.Copy(theParty.GetMembers(), 0, attackOrder, enemies.Length, theParty.GetMembers().Length);
        attackOrder = GetAttackOrder(attackOrder);

        //Fix this entire foreach loop and every method in it.
        //Each combatant will attack. If it kills someone, it checks if the battle should end
        bool loop = true;
        foreach (BattleInfo combatant in attackOrder)
        {
            if (combatant.GetStats().GetCurrentStat(0) > 0)
            {
                battleText.text = combatant.GetName() + "uses" + combatant.GetNextMove().moveName;
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
                    BattleLoop();
                }
            }
        }
    }

    //returns true if ran away successfully
    public bool Run(BattleInfo user)
    {
        if (!canEscape)
        {
            battleText.text = "You can't run away, you coward.";
            return false;
        }
        else if (user.GetHoldItem().itemName == "smoke bomb")
        {
            BattleEnd("ran away");
            return true;
        }
        else if (UnityEngine.Random.Range(0, 1) == 0)
        {
            //Call run() or BattleEnd("ran away")?
            return true;
        }
        else
        {
            battleText.text = "You couldn't get away!";
            return false;
        }
    }

    private BattleInfo[] GetAttackOrder(BattleInfo[] attackOrder) //combatants is a list of the party and enemies in the battle
    {
        //Insert sorting algorithm. Use arrayList.
        return attackOrder;
    }

    private void BattleEnd(string outcome)
    {
        if (outcome == "victory")
        {
            battleText.text = "You defeated the enemies!";
            //Calculate exp
            int liveHeroes = 0;
            foreach (BattleInfo hero in theParty.GetMembers())
            {
                hero.RevertBattleInfo();
                if (hero.GetStatus() != "dead")
                {
                    liveHeroes += 1;
                }
            }
            int expGiven = totalExp / liveHeroes; // how much xp each hero 
            ShowVictoryScreen(expGiven, loot);
        }
        else if (outcome == "loss")
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.RevertBattleInfo();
            }
            theParty.ChangeMoney(-100);

            battleText.text = "Your Team has fallen...";

            bool loop = true;
            while (loop)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    loop = false;
                }
            }

            SceneManager.LoadScene(previousScene);
        }

        else //outcome = "ran away"
        {
            battleText.text = "You ran away!";
            bool loop = true;
            while (loop)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    loop = false;
                }
            }

        }
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

    public Enemy[] GetEnemies()
    { return enemies; }

    public void AddToTotalExp(int amount)
    {
        totalExp += amount;
    }

    private void ShowVictoryScreen(int expToGive, InventoryItem[] loot)
    {
        
        foreach (Hero member in theParty.GetMembers())
        {
            member.AddExperience(expToGive);
        }
        foreach (InventoryItem item in loot)
        {
            theParty.AddToInventory(item);
        }

        bool loop = true;
        while (loop)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                loop = false;
            }
        }

        SceneManager.LoadScene(previousScene);
    }
}
 