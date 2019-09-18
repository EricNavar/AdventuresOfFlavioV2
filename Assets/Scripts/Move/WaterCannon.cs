using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class WaterCannon : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Water cannon";
		//The description you see in the character's profile
		//description = "Rest the next turn.";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = "water";
		baseAttack = 150;
		accuracy = .9f;
		priority = 0;
		sp = 12;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}