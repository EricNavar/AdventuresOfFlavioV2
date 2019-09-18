using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScale : InventoryItem
{
    public void Start()
    {
        itemName = "Dragon scale";
	    sellingPrice = 100;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}