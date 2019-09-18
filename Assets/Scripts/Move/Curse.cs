using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Curse : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Curse";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = "dark";
		baseAttack = 0;
		accuracy = .8f;
		priority = 0;
		sp = 8;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = "curse";
		effectRate = .8f;
		recoil = 0f;
	}
    
}