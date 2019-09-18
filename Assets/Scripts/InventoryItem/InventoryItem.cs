using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour {

    public int sellingPrice;
    public string itemName;
    public bool isBattleItem; // Can you use it in battle?
    public bool isOverWorldItem;
    public bool isUsable;
    public int amountStored;
    //public SpriteRenderer icon;
    public bool isKeyItem;
        
    /*
	// Update is called once per frame
	void Update () {
		
	}
    */

    public void changeAmountStored()//Change the amount of this item in the inventory
    {
        amountStored--;
        if (amountStored == 0)
        {
            Destroy(this);
        }
    }
}
