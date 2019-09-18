using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class IceBeam : Move {
	
	//ice_beam = move(x, , 100, "ice", "special", "foe", {"effect": "freeze", "accuracy": 15}, 10, 0)

	// Use this for initialization
	void Start () {
		moveName = "ice beam";
		//The description you see in the character's profile
		description = "A powerful ice attack. May freeze";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = "ice";
		baseAttack = 100;
		accuracy = 15;
		priority = 0;
		sp = 10;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = "freeze";
		effectRate = .15f;
		recoil = 0f;
	}
    
}