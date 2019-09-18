using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class RockBlast : Move {
	
	//rock_blast = move("rock blast", description, power, element, type_, targets, effect, sp, priority)

	// Use this for initialization
	void Start () {
		moveName = "Rock blast";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 90;
		accuracy = 100;
		priority = 0;
		sp = 10;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0;
		recoil = 0f;
	}
    
}