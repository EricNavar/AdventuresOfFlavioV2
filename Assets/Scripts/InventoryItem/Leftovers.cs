using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftovers: InventoryItem
{
    public void Start()
    {
        sellingPrice = 3500;
        itemName = "Leftovers";
        isBattleItem = true;
        isOverWorldItem = false;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}