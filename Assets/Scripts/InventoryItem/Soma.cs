using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soma : InventoryItem
{
    public void Start()
    {
        sellingPrice = 500;
        itemName = "soma";
		isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}