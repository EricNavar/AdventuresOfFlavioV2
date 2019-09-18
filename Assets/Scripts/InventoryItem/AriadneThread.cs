using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AriadneThread : InventoryItem
{
    public void Start(){
        sellingPrice = 200;
        itemName = "Adiadne Thread";
        isBattleItem = false;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}