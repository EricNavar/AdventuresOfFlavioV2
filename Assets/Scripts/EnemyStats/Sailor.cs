using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sailor : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Sailor";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();

        moveSet.Add(new Slash());
        holdItem = new GoldenNugget();
        expToGive = 10;
        weakness = null;// fix. and also dark
        resistance = "water";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}