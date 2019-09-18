using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XDefence : InventoryItem
{
    public void Start()
	{
		sellingPrice = 200;
		itemName = "XDefence";
		isBattleItem = true;
		isOverWorldItem = false;
		isUsable = true;
		//icon = true;
		isKeyItem = false;
	}	
}