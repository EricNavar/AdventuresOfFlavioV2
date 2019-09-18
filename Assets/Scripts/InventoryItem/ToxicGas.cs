using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicGas : InventoryItem
{
    public void Start(){
        sellingPrice = 500;
        itemName = "ToxicGas";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}