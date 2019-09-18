using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerveGas : InventoryItem
{
    public void Start(){
        sellingPrice = 500;
        itemName = "Nerve Gas";
        isBattleItem = true;
        isOverWorldItem = false;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}