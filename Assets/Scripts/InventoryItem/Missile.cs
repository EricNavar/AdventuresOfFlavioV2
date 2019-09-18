using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile: InventoryItem
{
    public void Start()
    {
        itemName = "Missile";
		sellingPrice = 3000;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}