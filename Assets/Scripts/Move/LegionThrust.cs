using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class LegionThrust : Move {
	
	//legion_thrust = move(, , 50, None, "physical", "all foes", None, 15, 0)

	// Use this for initialization
	void Start () {
		moveName = "legion thrust";
        //The description you see in the character's profile
        description = "A physical attack toward all enemies";
        //In battle, the move will cause this text to appear. 
        //battleText = ;
        type = null;
		baseAttack = 50;
		accuracy = .95f;
		priority = 0;
		sp = 15;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}