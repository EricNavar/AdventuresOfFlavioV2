using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//dive = move("dive", "Dives into water and attacks one turn later", 60, "water", type_, "foe", effect, sp, "delay")

 class Dive : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Dive";
		//The description you see in the character's profile
		description = "Dives into water and attacks one turn later";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = "water";
		baseAttack = 60;
        accuracy = 1f;
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