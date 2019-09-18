using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class NightmareCurse : Move {
	
	void Start () {
		moveName = "Nightmare curse";
        description = "absorbs energy of sleeping enemies";
        type = "dark";
		baseAttack = 90;
		accuracy = .90f;
		priority = 0;
		sp = 6;
		targets = "foe";
		contact = false;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        if (user.GetNextTargets()[0].GetStatus() == "sleeping")
        {
            base.UseMove(user);//Fix
            Debug.Log(user.GetName() + " absorbed HP!");
        }
        else
        {
            Debug.Log("The foe must be sleeping to use Nightmare curse!");
        }
    }
    
}