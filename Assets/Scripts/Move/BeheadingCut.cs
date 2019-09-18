using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class BeheadingCut : Move {
	
	//beheading_cut = move(, , 50, None, "physical", "f0e", {"effect": "dead", "accuracy": 25}, 10, 0)

	// Use this for initialization
	void Start () {
		moveName = "beheading cut";
		//The description you see in the character's profile
		description = "A slice at the enemy's head. May KO.";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 50;
		accuracy = .9f;
		priority = 0;
		sp = 10;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}


    public new void UseMove(BattleInfo user)
    {
        Enemy target = (Enemy)user.GetNextTargets()[0];
        if ( target.boss)
        {
            if (Random.Range(0, 1) > .2)
            {
                user.GetNextTargets()[0].Die();
                Debug.Log("KO!");
            }
            else
            {
                base.UseMove(user);
            }
        }
        else
        {
            base.UseMove(user);
        }
    }

}