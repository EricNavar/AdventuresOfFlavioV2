using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAxe: Equipment
{
    public void Start()
    {
        sellingPrice = 500;
        itemName = "Battle Axe";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
		int[] statToBoost = { 3 };
    	int[] boost = { 20 };

		/*1- HP
     	*2- SP
    	* 3- Attack
    	* 4- Defence
    	* 5- Speed
    	* 6- accuracy
    	* 7- evasiveness
    	* 8- Boost
    	*/
    }
}