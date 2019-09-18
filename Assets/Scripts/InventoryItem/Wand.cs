using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand: InventoryItem
{
    public void Start()
    {
        itemName = "Wand";
        sellingPrice = 300;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}