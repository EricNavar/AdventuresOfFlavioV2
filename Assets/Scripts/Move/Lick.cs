using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Lick : Move {
	
	//lick = move("lick", "The friendly lick of the cutest puppy in the world.", 1, None, "physical", "foe", effect, sp, -1)

	// Use this for initialization
	void Start () {
		moveName = "Lick";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 1;
		accuracy = 1f;
		priority = 2;
		sp = 0;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}