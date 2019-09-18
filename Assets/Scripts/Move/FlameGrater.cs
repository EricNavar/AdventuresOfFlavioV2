using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FlameGrater : Move {
	
    void Start () {
		moveName = "flame grater";
        description = "elemental sword attack to an enemy. Attacks first.";
        type = "fire";
		baseAttack = 55;
		accuracy = 1f;
		priority = 0;
		sp = 7;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}