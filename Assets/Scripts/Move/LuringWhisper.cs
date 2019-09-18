using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class LuringWhisper : Move {
	
	
	void Start () {
		moveName = "Luring whisper";//anesthetic
        description = "Luring whisper toward all enemies that ma induce sleep";
        type = null;
		baseAttack = 0;
		accuracy = .3f;
		priority = 0;
		sp = 0;
		targets = "enemies";
		//does the move make contact with the enemy like a punch?
		contact = false;
		secondaryEffect = "sleep";
		effectRate = .3f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        foreach (BattleInfo target in user.GetNextTargets())
        {
            if (Random.Range(0,1) > effectRate)
            {
                target.SetStatus(secondaryEffect);
                Debug.Log(target.GetName() + " fell asleep!");
            }
        }

    }
    
}