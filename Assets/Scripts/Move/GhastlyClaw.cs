using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GhastlyClaw : Move {

	void Start () {
		moveName = "ghastly claw";
        description =  "Summons a ghastly claw to attack an enemy";
        type = "dark";
		baseAttack = 30;
		accuracy = 1f;
		priority = 0;
		sp = 5;
		targets = "foe";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}