using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class RetaliateAttack : Move {
	
	//retaliate = move(, , 1.5, None, "physical", "foe", {"effect": "retaliate", "accuracy": 25}, 15, -1)

	// Use this for initialization
	void Start () {
		moveName = "retaliate";
        description = "retaliates a physical attack with a stronger attack";
        type = null;
		//baseAttack = 0;
		accuracy = 1f;
		priority = -1;
		sp = 15;
		targets = "foe";
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}