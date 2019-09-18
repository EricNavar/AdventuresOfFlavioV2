using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamePuff : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Flame Puff";
        boss = true;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new FireFormula());
        //moveSet.Add(new Slash());

        holdItem = new Charcoal();
        expToGive = 10;
        weakness = "ice";// fix. and also dark
        resistance = "fire";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}