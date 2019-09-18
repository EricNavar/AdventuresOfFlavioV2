using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FrigidSlash : Move {
	
	void Start () {
		moveName = "frigid slash";
		description = "elemental sword attack to an enemy. Attacks first";
		type = "ice";
		baseAttack = 55;
		accuracy = .9f;
		priority = 1;
		sp = 7;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}