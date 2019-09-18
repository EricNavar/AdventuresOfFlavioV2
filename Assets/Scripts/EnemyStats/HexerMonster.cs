using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexer_Monster : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Hexer";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new HeadBash());
        moveSet.Add(new Curse());

        holdItem = new Cloak();
        expToGive = 10;
        weakness = "fire";
        resistance = "dark";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}