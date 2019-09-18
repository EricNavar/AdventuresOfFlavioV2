using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Flamethrower : Move {
	
	//flamethrower = move(, , 100, "flame", "special", "foe", {"effect": "burn", "accuracy": 15}, 10, 0)

	// Use this for initialization
	void Start () {
		moveName = "flamethrower";
        //The description you see in the character's profile
        description = "A powerful flame attack. May burn.";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = "fire";
		baseAttack = 100;
		accuracy = .95f;
		priority = 0;
		sp = 15;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = "burn";
		effectRate = .15f;
		recoil = 0f;
	}
    
}