using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWolf : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Fire wolf";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Slash());
        //moveSet.Add(new Slash());

        holdItem = new WolfPelt();
        expToGive = 10;
        weakness = "water";
        resistance = "fire";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}