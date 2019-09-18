using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR15 : InventoryItem
{
    public void Start()
    {
        sellingPrice = 10000;
        itemName = "AR-15";
        isBattleItem = true;
        isOverWorldItem = false;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}