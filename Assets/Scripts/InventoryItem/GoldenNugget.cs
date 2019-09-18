using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenNugget : InventoryItem
{
    public void Start()
    {
        sellingPrice = 5000;
        itemName = "GoldenNugget";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = true;
        isKeyItem = false;
    }
}