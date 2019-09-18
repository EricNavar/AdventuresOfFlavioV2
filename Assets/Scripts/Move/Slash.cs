using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Slash : Move {
	
	//slash = move("slash", "slash with your sword", 30, None, "physical", "foe", None, 3, 0)

	// Use this for initialization
	public Slash() {
		moveName = "Slash";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 30;
		accuracy = 1f;
		priority = 0;
		sp = 3;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;//?
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}