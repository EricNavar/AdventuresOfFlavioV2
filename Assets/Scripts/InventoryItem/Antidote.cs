using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antidote : InventoryItem
{
    public void Start(){
        sellingPrice = 150;
        itemName = "Antidote";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}