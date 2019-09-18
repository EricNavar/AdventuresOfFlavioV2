using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fang : InventoryItem
{
    public void Start()
    {
        itemName = "Fang";
        sellingPrice = 35;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}