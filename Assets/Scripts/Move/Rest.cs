using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Rest : Move {
	
	// Use this for initialization
	public Rest() {
		moveName = "Rest";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 0;
		accuracy = 0;
		priority = 0;
		sp = 5;
		targets = "self";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}