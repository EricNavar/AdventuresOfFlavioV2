using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Revive_Move : Move {
	
	void Start () {
		moveName = "Revive";
        //The description you see in the character's profile
        description = "revives an ally";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = null;
		baseAttack = 0;
		accuracy = 0;
		priority = 0;
		sp = 20;
		targets = "ally";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        BattleInfo target = user.GetNextTargets()[0];
        if (target.GetStatus() == "dead")
        {
            target.SetStatus(null);
            target.GetStats().ChangeHP(.5f);
        }
        else
        {
            Debug.Log("THIS SHOULD NOT PRINT");
        }
    }
}