using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Shoot : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Shoot";
		//The description you see in the character's profile
		description = "You shoot someone with an AR-15. Your aim is really bad though.";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 500;
		accuracy = .4f;
		priority = 0;
		sp = 50;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}