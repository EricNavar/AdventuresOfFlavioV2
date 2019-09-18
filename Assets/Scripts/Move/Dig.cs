using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Dig : Move {
	
	//dig = move("dig", , 60, element, type_, "foe", effect, sp, "delay")

	// Use this for initialization
	void Start () {
		moveName = "Dig";
        //The description you see in the character's profile
        description = "Digs into the ground and attacks one turn later";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = null;
		baseAttack = 60;
		accuracy = .90f;
		priority = 0;
		sp = 12;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}