using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ClearStance : Move {

	// Use this for initialization
	void Start () {
		moveName = "clear stance";
        description = "Increases accuracy";
        type = null;
		baseAttack = 0;
		accuracy = 0;
		priority = 0;
		sp = 5;
		targets = "self";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
    public new void UseMove(BattleInfo user)
    {
        user.GetStats().AddBuff(6,1);
        Debug.Log(user.GetName() + "'s accuracy was increased.");
    }
}