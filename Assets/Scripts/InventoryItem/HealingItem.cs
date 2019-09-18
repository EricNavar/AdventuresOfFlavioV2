using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour {

    /* 1- HP
    * 2- Attack
    * 3- Defence
    * 4- Speed
    * 5- Boost
    * 6 accuracy
    * 7 evasiveness
    */

    public int statNum;
    public int healingAmount;
    public float healingPercent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void useItem(Hero thePlayer)
    {
        thePlayer.GetStats().ChangeHP(healingAmount);
    }
}
