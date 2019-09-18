using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PoisonShot : Move {

	void Start () {
		moveName = "poison shot";
        description = "A jab that may poison the enemy";
		type = null;
		baseAttack = 100;
		accuracy = .95f;
		priority = 0;
		sp = 15;
		targets = "foe";
		contact = true;
		secondaryEffect = "poison";
		effectRate = .15f;
		recoil = 0f;
	}
    
}