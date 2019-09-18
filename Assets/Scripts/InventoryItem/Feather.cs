using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feather : InventoryItem
{
    public void Start()
    {
        itemName = "feather";
		sellingPrice = 10;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}