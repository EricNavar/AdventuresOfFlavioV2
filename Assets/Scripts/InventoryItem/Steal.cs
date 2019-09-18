using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Steal : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Steal";
		//The description you see in the character's profile
		description = "The user steals the target's hold item.";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 30;
		accuracy = .75f;
		priority = 0;
		sp = 5;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}