using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Defend : Move {
	
	void Start () {
		moveName = "Defend";
		type = null;
		baseAttack = 0;
		accuracy = 0f;
		priority = 3;
		sp = 0;
		targets = "self";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        user.GetStats().AddBuff(4,1);
        Debug.Log(user.GetName() + "'s defence was increased.");
    }

}