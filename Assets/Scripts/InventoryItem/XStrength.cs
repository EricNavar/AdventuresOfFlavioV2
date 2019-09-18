using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XStrength : InventoryItem
{
    public void Start()
    {
        sellingPrice = 200;
        itemName = "XStrength";
        isBattleItem = true;
        isOverWorldItem = false;
        isUsable = true;
        //icon = true;
        isKeyItem = false;
    }
}