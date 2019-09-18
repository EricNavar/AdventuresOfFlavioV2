using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ThorFormula : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Thor formula";
		description = "A volt attack at all enemies";
		type = "volt";
		baseAttack = 70;
		accuracy = 95;
		priority = 0;
		sp = 25;
		targets = "all foes";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0;
	}
    
}