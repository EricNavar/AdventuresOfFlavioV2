using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class RagingEdge : Move {
	
	//raging_edge = move(, , 100, None, "physical", "all foes", None, 10, 0)

	// Use this for initialization
	void Start () {
		moveName = "raging edsge";
		//The description you see in the character's profile
		description = "A powerful slash attack";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 100;
		accuracy = .9f;
		priority = 0;
		sp = 12;
		targets = "all";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}