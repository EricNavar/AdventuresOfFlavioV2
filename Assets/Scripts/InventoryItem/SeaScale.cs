using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaScale: InventoryItem
{
    public void Start()
    {
        itemName = "Sea scale";
        sellingPrice = 30;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}