using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelScrap: InventoryItem
{
    public void Start()
    {
        itemName = "SteelScrap";
		sellingPrice = 25;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}