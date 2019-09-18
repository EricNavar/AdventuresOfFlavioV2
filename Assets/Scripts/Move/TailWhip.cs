using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class TailWhip : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Tail whip";
		//The description you see in the character's profile
		description = "the user slams his tail into his foe.";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 120;
		accuracy = .65f;
		priority = 0;
		sp = 8;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}