using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LightningStab : Move {
	
	void Start () {
		moveName = "lightning stab";
        description = "elemental sword attack to an enemy. Attacks first.";
        type = "volt";
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