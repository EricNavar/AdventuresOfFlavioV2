using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcoal : InventoryItem
{
    public void Start()
    {
        itemName = "Charcoal";
		sellingPrice = 40;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}