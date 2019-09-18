using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class HeadBash : Move {
	
	//head_bash = move("head bash", , 140, None, "physical", "foe", effect, 15, 0) #low accuracy

	// Use this for initialization
	void Start () {
		moveName = "Head bash";
        description = "Powerful bash against enemy. Badly hurts the user.";
        type = null;
		baseAttack = 140;
		accuracy = 85;
		priority = 0;
		sp = 18;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = .3f;
	}
    
}