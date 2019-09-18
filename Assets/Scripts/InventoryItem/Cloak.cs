using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloak : InventoryItem
{
    public void Start(){
        sellingPrice = 3000;
        itemName = "Cloak";
        isBattleItem = true;//?
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}