using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeTooth : InventoryItem
{
    public void Start()
    {
        itemName = "Large tooth";
        sellingPrice = 100;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}