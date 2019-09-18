using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class BodySlam : Move {
	
	//body_slam = move("body slam", "All of the user's weight is slammed against the foe. May paralyze", 90, None, "physical", "foe", {"effect": "paralyze", "accuracy": 10}, 9, 0)

	// Use this for initialization
	void Start () {
		moveName = "Body slam";
		description = "All of the user's weight is slammed against the foe. May paralyze";
		type = null;
		baseAttack = 90;
		accuracy = .90f;
		priority = 0;
		sp = 9;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = "paralyze";
		effectRate = .1f;
		recoil = 0f;
	}
}