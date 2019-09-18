using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Gunner";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Shoot());
        //moveSet.Add(new Slash());
        holdItem = new AR15();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}