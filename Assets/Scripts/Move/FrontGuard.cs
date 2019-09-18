using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class FrontGuard : Move {
	
	//front_guard = move(, , 1.2, None, "stats", "party", {"effect": "defence", "accuracy": 100}, 6, 1)

	// Use this for initialization
	void Start () {
		moveName = "front guard";
        //The description you see in the character's profile
        description = "raises defence of party at the start of this turn";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = null;
		baseAttack = 0;
		accuracy = 0f;
		priority = 3;
		sp = 6;
		targets = "front party";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        foreach (BattleInfo member in user.GetNextTargets())
        {
            member.GetStats().AddBuff(4,2);
        }
        Debug.Log("The defence of the front line was increased.");
    }
    
}