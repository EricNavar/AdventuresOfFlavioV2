using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePuff : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Ice Puff";
        boss = true;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new IceBeam());
        moveSet.Add(new IceShard());
        holdItem = new SuperPotion();
        expToGive = 10;
        weakness = "fire";// fix. and also dark
        resistance = "ice";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}