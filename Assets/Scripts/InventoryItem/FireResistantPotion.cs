using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireResistantPotion : InventoryItem
{
    public void Start()
    {
        sellingPrice = 100;
        itemName = "Fire resistant potion";
        isBattleItem = false;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}