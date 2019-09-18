using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceStone: InventoryItem
{
    public void Start()
    {
        itemName = "Ice stone";
	    sellingPrice = 200;
        isBattleItem = false;
        isOverWorldItem = true;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}