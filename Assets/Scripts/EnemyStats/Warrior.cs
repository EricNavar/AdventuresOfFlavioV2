using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Warrior";
        boss = true;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new ShieldRush());
        moveSet.Add(new Fortify());
        holdItem = new SteelScrap();// or steel shield
        expToGive = 10;
        weakness = null;
        resistance = null;
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}