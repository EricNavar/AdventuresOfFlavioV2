using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalysisLens : InventoryItem
{
    public void Start(){
        sellingPrice = 4000;
        itemName = "Analysis Lens";
        isBattleItem = true;//?
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}