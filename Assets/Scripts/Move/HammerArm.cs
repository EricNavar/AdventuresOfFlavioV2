using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class HammerArm : Move {

	void Start () {
        moveName = "hammer arm";
		description = "A powerful brute force against an enemy. The user takes recoil.";
		type = null;
		baseAttack = 100;
		accuracy = 1f;
		priority = 0;
		sp = 10;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = .2f;
	}
    
}