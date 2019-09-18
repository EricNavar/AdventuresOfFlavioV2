using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class IceShard : Move {
	
	//ice_shard = move("ice shard", "Shoots a wave of icecicles to  enemies", 40, "ice", type_, "random", effect, 20, 0)

	// Use this for initialization
	void Start () {
		moveName = "Ice shard";
		//The description you see in the character's profile
		description = "Shoots a wave of icecicles to enemies";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 70;
		accuracy = .7f;
		priority = 0;
		sp = 15;
		targets = "all";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = "frozen";
		effectRate = .2f;
		recoil = 0f;
	}
    
}