using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishedIce: InventoryItem
{
    public void Start()
    {
        itemName = "Extinguished ice";
        sellingPrice = 800;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}