using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class PoisonSting : Move {
	
	//poison_sting = move("poison sting", "A stab with a needle covered in poison. May poison.", power, element, type_, targets, effect, sp, priority)

	// Use this for initialization
	void Start () {
		moveName = "Poison sting";
		//The description you see in the character's profile
		//description = ;
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 80;
		accuracy = .95f;
		priority = 0;
		sp = 12;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect ="poison" ;
		effectRate = .2f;
		recoil = 0f;
	}
    
}