using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horn: InventoryItem
{
    public void Start()
    {
        itemName = "Horn";
        sellingPrice = 15;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}