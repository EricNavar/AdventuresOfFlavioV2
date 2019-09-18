using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPelt : InventoryItem
{
    public void Start()
    {
        itemName = "Wolf pelt";
		sellingPrice = 28;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}