//water_cannon = move("water cannon", "A very powerful shot of high pressure water. Hits first.", 150, "water", type_, "foe", effect, 25, 1)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//dragon_claw = move("dragon claw", "description", 95, element, "physical", targets, effect, sp, priority)

 class DragonClaw : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Dragon claw";
        description = "A clawed attack to a foe.";
		type = null;
		baseAttack = 90;
		accuracy = .95f;
		priority = 0;
		sp = 12;
		targets = "foe";
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
}