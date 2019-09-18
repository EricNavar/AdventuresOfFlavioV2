using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenShield : Equipment
{
    public void Start()
    {
        sellingPrice = 500;
        itemName = "Wooden shield";
        isBattleItem = false;
        isOverWorldItem = false;
        isUsable = false;
        //icon = 
        isKeyItem = false;

        int[] statToBoost;
        int[] boost;

        /*1- HP
        *2- SP
        * 3- Attack
        * 4- Defence
        * 5- Speed
        * 6- accuracy
        * 7- evasiveness
        * 8- Boost
        */
    }
}