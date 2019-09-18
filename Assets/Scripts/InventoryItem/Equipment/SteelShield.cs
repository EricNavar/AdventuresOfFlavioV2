using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelShield : Equipment
{
    public void Start()
    {
        itemName = "Steel shield";
		sellingPrice = 300;
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;
    }
}