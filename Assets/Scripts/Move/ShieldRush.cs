using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ShieldRush : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Shield Rush";
		description = "An attack toward all enemies. May reduce the defence of the target.";
		type = null;
		baseAttack = 50;
		accuracy = .95f;
		priority = 0;
		sp = 10;
		targets = "enemies";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {

    }
    
}