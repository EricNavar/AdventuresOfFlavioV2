using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Seaborne dragon";
        boss = true;
        description = "This dragon has the form of giant eel. It can hide its wings along its body and swim through the ocean.";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new IceBeam());
        moveSet.Add(new Flamethrower());
        moveSet.Add(new TailWhip());
        moveSet.Add(new WingSlash());

        holdItem = new LifeGem();// fix. also charcoal
        expToGive = 500;
        weakness = "volt";
        resistance = "fire";
        stats.CreateNewStats(70, 60, 30, 55, 25);
    }
}