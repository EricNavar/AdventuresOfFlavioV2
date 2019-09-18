using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherScrap : InventoryItem
{
    public void Start()
    {
        itemName = "Leather scrap";
        sellingPrice = 200;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}