using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Swift : Move {
	
	//swift = move("swift", "Cannot miss", 50, None, "special", "fie", effect, 8, 0) #cannot miss

	// Use this for initialization
	void Start () {
		moveName = "Swift";
		description = "This attack will never miss";
		type = null;
		baseAttack = 50;
		accuracy = 0;
		priority = 0;
		sp = 8;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}
    
    public new void UseMove(BattleInfo user)
    {
        accuracy = 64f;
        base.UseMove(user);
        accuracy = 0;
    }

}