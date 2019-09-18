using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class FranticRush : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Frantic rush";
		//The description you see in the character's profile
		description = "Ends the battle is successful.";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 0;
		accuracy = .85f;
		priority = 0;
		sp = 0;
		targets = "party";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}