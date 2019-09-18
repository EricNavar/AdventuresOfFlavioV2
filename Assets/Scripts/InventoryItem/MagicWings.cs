using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWings : InventoryItem
{
    public void Start()
    {
        itemName = "Magic wings";
	    sellingPrice = 8;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}