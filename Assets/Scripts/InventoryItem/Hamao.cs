using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamao : InventoryItem
{
    public void Start(){
        sellingPrice = 1000;
        itemName = "Hamao";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}