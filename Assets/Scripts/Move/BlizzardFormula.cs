using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BlizzardFormula : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Blizzard formula";
		description = "An freezing wave toward all enemies";
		type = "ice";
		baseAttack = 120;
		accuracy = .7f;
		priority = 0;
		sp = 10;
		targets = "enemies";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}