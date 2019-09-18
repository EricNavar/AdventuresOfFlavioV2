using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalShield: Equipment
{
    public void Start()
    {
        sellingPrice = 8000;
        itemName = "Crystal shield";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;

        /*1- HP
     	* 2- SP
    	* 3- Attack
    	* 4- Defence
    	* 5- Speed
    	* 6- accuracy
    	* 7- evasiveness
    	* 8- Boost
    	*/
    }
}