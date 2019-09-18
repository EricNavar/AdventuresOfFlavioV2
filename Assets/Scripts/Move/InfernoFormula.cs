using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class InfernoFormula : Move {
	
	//inferno_formula = move("fire formula", "A flame attack at all enemies", 70, "flame", "special", "all foes", {"effect": "burn", "accuracy": 20}, 25, 0)

	// Use this for initialization
	void Start () {
		moveName = "Inferno formula";
		//The description you see in the character's profile
		description = "A flame attack at all enemies";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = "fire";
		baseAttack = 70;
		accuracy = .7f;
		priority = 0;
		sp = 25;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}