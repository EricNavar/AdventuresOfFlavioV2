using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeBomb : InventoryItem
{
    public void Start()
    {
        sellingPrice = 1000;
        itemName = "smoke bomb";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}