using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Golem";
        boss = true;
        description = "Monster make of rocks. Has a shield.";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new BodySlam());
        moveSet.Add(new BoulderFist());
        holdItem = new SteelShield();
        expToGive = 10;
        weakness = "ice";
        resistance = "fire";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}