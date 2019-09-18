using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxRevive : Revive
{
    public new void Start(){
        sellingPrice = 1000;
        itemName = "MaxRevive";
        isBattleItem = true;
        isOverWorldItem = true;
        isUsable = true;
        //icon = 
        isKeyItem = false;
    }
}