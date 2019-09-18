using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class VoltFormula : Move {
	
	void Start () {
		moveName = "volt formula";
        description = "A volt attack at one enemy";
        type = "volt";
		baseAttack = 70;
        accuracy = .95f;
		priority = 0;
		sp = 8;
		targets = "foe";
		contact = false;
		secondaryEffect = "paralize";
		effectRate = .1f;
		recoil = 0f;
	}
    
}