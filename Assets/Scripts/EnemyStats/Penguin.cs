using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Penguin";
        boss = true;
        description = "Fatass Penguin";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new BlizzardFormula());
        moveSet.Add(new Slash());

        holdItem = new IceStone();
        expToGive = 10;
        weakness = "fire";// fix. and also dark
        resistance = "ice";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}