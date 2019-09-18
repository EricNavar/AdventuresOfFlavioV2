using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTarget : MonoBehaviour {

    BattleManager theBattle;
    private Vector2[] positions;

    private void Start()
    {
        theBattle = FindObjectOfType<BattleManager>();
    }

    public void AssignTarget(Hero user)
    {
        string target = user.GetNextMove().targets;

        if (target == "enemies")
        {
            user.SetNextTarget(theBattle.GetEnemies());
        }
        else if (target == "self")
        {
            user.SetNextTarget(new BattleInfo[] { user });
        }
        else if (target == "party")
        {
            user.SetNextTarget(theBattle.theParty.GetMembers());
        }
        else if (target == "foe")
        {
            Choose( theBattle.GetEnemies() , user );
            
        }
        else //if (target == "party member")
        {
            Choose( theBattle.theParty.GetMembers() , user );
        }
    }
    
    /*
    private Vector2[] SetPosition(StatHolder[] targets)
    {
        string str;
        int offset;

        if ("PlayerStats" == targets.GetType())
        {
            offset = 100;
            str = "ally";
        }
        else if (targets == typeof(EnemyStats[]))
        {
            offset = -100;
            str = "foe";
        }
        theBattle.battleText = "Which " + str + "?";
        positions = new Vector2[targets.Length];
        for (int i = 0; i < user.GetNextTargets().Length; i++)
        {
            position[i] = new Vector2 (targets[i].position.x, targets[i].position.y + offset);
        }
    }
    */

    private void Choose(BattleInfo[] options, BattleInfo user)
    {
        //GameObject selectionArrow = Instantiate(Resources.Load())
        //Vector2[] positions = SetPosition(options);
        int selection = 0;
        bool loop = true;
        while (loop)
        {
            if ( Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.D) )
            {

                if (selection > 0)
                {
                    selection--;
                    theBattle.battleText.text = selection.ToString();
                }
            }
            else if ( Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A) )
            {
                if (selection < positions.Length - 1)
                {
                    selection++;
                    theBattle.battleText.text = selection.ToString();
                }
            }
            else if ( Input.GetKeyDown(KeyCode.J ) )
            {
                user.SetNextTarget( new BattleInfo[] { options[selection] } );
                loop = false;
            }
        }
    }

}
