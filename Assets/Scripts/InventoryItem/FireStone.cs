using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStone : InventoryItem
{
    public void Start()
    {
        itemName = "Fire stone";
		sellingPrice = 200;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}