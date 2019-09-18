using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Earthquake : Move {

	void Start () {
		moveName = "earthquake";
        description = "A powerful earthquake hits all foes but also allies.";
        type = null;
		baseAttack = 100;
		accuracy = 1f;
		priority = 0;
		sp = 20;
		targets = "all";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}