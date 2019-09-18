using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Toxin : Move {
	
	void Start () {
		moveName = "toxin";
        description = "May poison the enemy";
        type = null;
		baseAttack = 0;
		accuracy = .95f;
		priority = 0;
		sp = 8;
		targets = "foe";
		contact = false;
		secondaryEffect = "poison";
		effectRate = .95f;
		recoil = 0;
	}
}