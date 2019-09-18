using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carminite : InventoryItem
{
    public void Start()
    {
        itemName = "Carminiite";
	    sellingPrice = 18;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}