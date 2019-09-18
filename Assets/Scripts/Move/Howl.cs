using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Howl : Move {
	
	// Use this for initialization
	void Start () {
		moveName = "Howl";
		description = "Lowers the enemy's attack";
		type = null;
		baseAttack = 0;
		accuracy = .95f;
		priority = 0;
		sp = 3;
		targets = "foe";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}


    public new void UseMove(BattleInfo user)
    {
        foreach (BattleInfo target in user.GetNextTargets())
        {
            target.GetStats().AddBuff(3,-1);
            Debug.Log(user.GetName() + "'s attack was decreased.");
        }
    }
}