using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ParticleBeam : Move {
	
	//particle_beam = move(, , power, "volt", "special", "foe", effect, sp, 0)

	// Use this for initialization
	void Start () {
		moveName = "particle beam";
		//The description you see in the character's profile
		description = "A beam of charged particles to an enemy";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = "volt";
		baseAttack = 120;
		accuracy = .95f;
		priority = 0;
		sp = 15;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}