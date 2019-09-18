using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//corrupt_curse = move("corrupt curse", "Can curse an enemy", None, None, None, 1, {"effect": "curse", "accuracy": 50}, 8, 0)

class CorruptCurse : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "CorruptCurse";
        description = "An attack on the foe's soul. May curse the enemy.";
		type = "dark";
		baseAttack = 50;
		accuracy = .95f;
		priority = 0;
		sp = 12;
		targets = "foe";
		contact = false;
		secondaryEffect = "curse";
		effectRate = .3f;
		recoil = 0f;
	}
    
}