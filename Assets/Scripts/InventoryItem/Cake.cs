using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : InventoryItem
{
    public void Start(){
        sellingPrice = 600;
        itemName = "Cake";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}