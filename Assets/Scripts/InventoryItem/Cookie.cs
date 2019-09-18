using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie: InventoryItem
{
    public void Start()
    {
        sellingPrice = 1000;
        itemName = "Cookie";
        isBattleItem = true;;
        isOverWorldItem = true;;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}