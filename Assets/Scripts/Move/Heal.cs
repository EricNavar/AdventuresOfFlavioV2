using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Heal : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Heal";
		description = "Removes any status effects.";
		type = null;
		baseAttack = 0;
		accuracy = 0;
		priority = 0;
		sp = 8;
		targets = "party";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        BattleInfo target = user.GetNextTargets()[0];
        if (target.GetStatus() != "dead" && target.GetStatus() != null)
        {
            target.SetStatus(null);
            Debug.Log(target.GetName() + " was healed of ailments.");
        }
    }
}