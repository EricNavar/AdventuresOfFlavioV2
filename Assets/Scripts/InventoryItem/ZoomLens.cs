using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLens: InventoryItem
{
    public void Start()
    {
        sellingPrice = 4000;
        itemName = "Zoom Lens";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}