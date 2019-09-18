using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Fortify : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Fortify";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 0;
		accuracy = 0f;
		priority = 0;
		sp = 4;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        user.GetStats().AddBuff(3,1);
        Debug.Log(user.GetName() + "'s attack was increased.");
    }
}