using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class TakeDown : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Take down";
		description = "A strong attack but takes recoil";
		type = null;
		baseAttack = 120;
		accuracy = 1f;
		priority = 0;
		sp = 2;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = .25f;
	}
    
}
