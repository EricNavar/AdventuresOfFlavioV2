using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Stab : Move {
	
	//stab = move("stab", "stab an enemy", 40, None, "physical", "foe", None, 4, 1)

	// Use this for initialization
	void Start () {
		moveName = "Stab";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 50;
		accuracy = .85f;
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