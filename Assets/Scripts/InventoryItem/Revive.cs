using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revive : InventoryItem
{
    public void Start()
    {
        sellingPrice = 1000;
        itemName = "Revive";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}