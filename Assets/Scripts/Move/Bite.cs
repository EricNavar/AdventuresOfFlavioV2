using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bite : Move {
	
	void Start () {
		moveName = "Bite";
		description = "A bite at an enemy.";
		type = null;
		baseAttack = 70;
		accuracy = .95f;
		priority = 0;
		sp = 8;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
}