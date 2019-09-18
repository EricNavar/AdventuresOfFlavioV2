using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class BlindingLight : Move {
	
	//blinding_light = move(, , power, element, type_, targets, effect, sp, priority)

	// Use this for initialization
	void Start () {
		moveName = "blinding light";
        //The description you see in the character's profile
        description = "Lowers accuracy of foes.";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = null;
		baseAttack = 0;
		accuracy = .8f;
		priority = 0;
		sp = 8;
		targets = "enemies";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}