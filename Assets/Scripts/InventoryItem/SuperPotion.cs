using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPotion: InventoryItem
{
    public void Start()
    {
        itemName = "Super potion";
		sellingPrice = 200;
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}