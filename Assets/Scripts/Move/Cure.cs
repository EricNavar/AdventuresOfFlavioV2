using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Cure : Move {
	
	//cure = move("cure", , None, None, "status", "ally", {"effect": "status", "accuracy": 90}, 8, 0)

	// Use this for initialization
	void Start () {
		moveName = "Cure";
		//The description you see in the character's profile
		description = "removes an ailment";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 0;
		accuracy = 0;
		priority = 0;
		sp = 8;
		targets = "party member";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
    public new void UseMove(BattleInfo user)
    {
        foreach (BattleInfo target in user.GetNextTargets())
        {
            target.GetStats().ChangeHP(.5f);
        }
    }

}