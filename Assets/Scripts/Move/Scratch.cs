using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Scratch : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Scratch";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 40;
		accuracy = 1f;
		priority = 0;
		sp = 3;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}