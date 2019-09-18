using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rib: InventoryItem
{
    public void Start()
    {
        itemName = "Rib";
        sellingPrice = 25;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}