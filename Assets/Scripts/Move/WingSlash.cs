using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class WingSlash : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Winglash";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 60;
		accuracy = .9f;
		priority = 0;
		sp = 8;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0;
		recoil = 0f;
	}
    
}