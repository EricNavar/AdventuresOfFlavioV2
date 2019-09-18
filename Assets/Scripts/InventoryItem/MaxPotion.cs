using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxPotion : InventoryItem
{
    public void Start()
    {
        sellingPrice = 500;
        itemName = "Max potion";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}
