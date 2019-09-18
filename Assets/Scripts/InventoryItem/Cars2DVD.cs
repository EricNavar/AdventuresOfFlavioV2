using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars2DVD : InventoryItem
{
    public void Start()
    {
        itemName = "Cars 2 DVD";
		sellingPrice = 20000;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}