using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fire_formula = move("fire formula", "A flame attack at one enemy", 70, "flame", "special", "foe", {"effect": "burn", "accuracy": 10}, 8, 0)

 class FireFormula : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Fire formula";
        description = "A blast of fire toward one enemy.";
		type = "fire";
		baseAttack = 100;
		accuracy = .95f;
		priority = 0;
		sp = 10;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = "burn";
		effectRate = .2f;
		recoil = 0f;
	}
    
}
