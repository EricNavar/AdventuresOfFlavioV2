using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Attatched to Canvas
public class Hero : BattleInfo {

    private int currentExp;//Exp accumulated only in the current level
    public int currentLevel;
    public int[] toLevelUp;//How much currentExp you need to level up
    private Party theParty;
    private Canvas theCanvas;

	// Use this for initialization
	void Start ()
    {
        UIManager UI= FindObjectOfType<UIManager>();
        UI.SetHealthBar(stats.GetCurrentStat(0));
        theParty = FindObjectOfType<Party>();
	}
	
    public void addExperience(int experience)
    {
        currentExp += experience;
    }

    public void AddExperience(int experience)
    {
        //You can't go past Level 100
        if (currentLevel != 100)
        {
            currentExp += experience;
            if (currentExp > toLevelUp[currentLevel])
            {
                stats.LevelUp();
                currentExp = currentExp - toLevelUp[currentLevel];
                currentLevel++;
            }
        }
    }

    //Exp accumulated from all levels
    private int CalculateTotalExp()
    {
        int total = 0;
        foreach (int i in toLevelUp)
        {
            total += toLevelUp[i];
        }
        return total;
    }

    public override void Die()
    {
        stats.RevertAllStats();
        SetStatus("dead");
    }

    public void SetNextMove(Move move)
    {
        nextMove = move;
    }

    /*
    public void ChooseTurn()
    {
        Debug.Log("What will " + characterName + " do?");
        Debug.Log("attack\nskills\nitems\nrun");
        bool flag = false; //when flag is false, an option has not been chosen.
        while (flag == false)
        {
            //string user_input = input();
            string userInput = "placeholder";//fix
            if (userInput == "attack")
            {
                DecideTarget(moveSet[0], theBattle.GetEnemies());
                flag = true;
            }
            else if (userInput == "skills")
            {
                DecideAttack();
                flag = true;
            }
            else if (userInput == "items")
            {
                theParty.DisplayInventory();
                flag = true;
            }
            else if (userInput == "run")
            {
                theBattle.Run();
                flag = true;
            }
            else
            {
                Debug.Log("That is not an option.");
                continue;
            }
        }
    }
    

    public override void DecideAttack()
    {
        
        foreach (Attack attack in self.attacks[1:len(self.attacks) - 1])
        {
            Debug.Log(attack.name, end = ", ");

        }
        Debug.Log(self.attacks[-1].name)
        
        DisplayAttacks();

        
        while (true)
        {
            Debug.Log("What skill will " + characterName + "use?");
            //Fix
            string userInput = "placeHolder";
            foreach (Move move in moveSet)
            {
                if (userInput == move.name)
                {
                    if (move.sp > StatInfo.GetCurrentStat(1))
                    {
                        Debug.Log("You do not have enough sp for that move.");
                        //Canvas.Text = "You do not have enough sp for that move.";
                        break;
                    }
                    else
                    {
                        DecideTarget(move, theBattle.GetEnemies());
                        return;
                    }
                }
            }
        }
        

}



    
    private void DisplayAttacks()
    {
        
        string text = "";
        for ( int i = 0; i < moveSet.Length; i++)
        {
            text += i + ": " + moveName;
        }
        
    }


    private void DecideTarget(Move move, EnemyStats[] enemies)
    {
        StatInfo.SetNextMove(move);
        if (move.targets == "enemy")
        {
            /*
            if (theBattle.enemies.Length == 1)
            {
                nextTarget = theBattle.enemies[0];
                return;
            }
            bool flag2 = false;
            while (!flag2)
            {
                user_input = input("Which enemy will you attack?");
                foreach (StatHolder enemy in enemies)
                {
                    if (user_input == enemy.name)
                    {
                        nextTarget = enemy;
                        flag2 = true;
                    }
                }
                //else
                //{
                if (!flag2)
                {
                    Debug.Log("That is not a enemy.");
                }
                //}
            }
            
        }
        //Only one hero is in the game at the moment
        /* 
        else if (move.targets == "ally")
        {
            possible_targets = []
            foreach (member in theParty.getMembers())
            {
                if (member.name != characterName)
                {
                    possible_targets.append(member);
                }
            }
            while (true)
                user_input = input("Which ally will you help?");
                foreach (StatInfo hero in possible_targets)
                {
                    self.current_stats["next attack target"] = hero;
                    //flag2 = true
                    return;
                }
                else 
                {
                    //if (flag2 == false)
                    Debug.Log("That is not an ally.");
                    continue;
                }
        }
        
        else if (move.targets == "all enemies")
        {
            StatInfo.SetNextTarget(theBattle.enemies);
        }
        else if (move.targets == "self")
        {
            StatInfo.SetNextTarget( new[] { this } );
        }
        
        else if (move.targets == "party")
        {
            nextTarget = new[] { party };
        }
        
        else
        {
            Debug.Log("This should never print.");
        }
    }


    */


    /*
    private bool attack()//fix. Will this move be a part of battlemanager or playerstats? 
    {
        Move move = nextAttack;
        StatHolder target =
        Debug.Log(characterName + "uses" + move.moveName);
        float modifier = 1f;
        if (nextTarget.weakness == move.element)
        {
            modifier *= 2f;
        }
        if (nextTarget.resistance == move.element)
        {
            modifier *= .5f;
        }
        int damage = Mathf.ceil(move.baseAttack * getCurrentStat("attack") * modifier / nextTarget.getCurrent("defence"));

        //1 in 5 chance of getting a critical hit 
        if (random.Range(0, 5) == 0)
        {
            damage *= 2;
            Debug.Log("Critical hit!");
        }
        nextTarget.takeDamage(damage);
    }
    */
}
