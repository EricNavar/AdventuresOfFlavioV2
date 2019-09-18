using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSkin : InventoryItem
{
    public void Start()
    {
        itemName = "Snake skin";
		sellingPrice = 30;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}