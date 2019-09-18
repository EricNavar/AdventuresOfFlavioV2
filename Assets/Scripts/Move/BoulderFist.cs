using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class BoulderFist : Move {
	
	//boulder_fist = move("boulder fist", "", 80, None, "physical", "foe", None, 8, 0)

	// Use this for initialization
	void Start () {
		moveName = "BoulderFist";
		description = "A powerful attack with a rock-hard fist.";
		type = null;
		baseAttack = 80;
		accuracy = 1f;
		priority = 0;
		sp = 8;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}