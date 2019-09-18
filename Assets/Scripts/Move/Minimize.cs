using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Minimize : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Minimize";
		//The description you see in the character's profile
		description = "Increases evasiveness";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 0;
		accuracy = 0;
		priority = 0;
		sp = 8;
		targets = "self";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        user.GetStats().AddBuff(7,1);
        Debug.Log(user.GetName() + "'s evasiveness was increased.");
    }
}