using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class QuickAttack: Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Quick attack";
		description = "An attack that attacks first.";
		type = null;
		baseAttack = 30;
		accuracy = .95f;
		priority = 1;
		sp = 2;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0;
        recoil = 0;
	}
    
}
