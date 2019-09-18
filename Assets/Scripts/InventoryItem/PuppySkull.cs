using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuppySkull: InventoryItem
{
    public void Start()
    {
        sellingPrice = 10;
        itemName = "Puppy skull";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}