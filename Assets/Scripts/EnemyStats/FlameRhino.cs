using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameRhino : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Flame Rhino";
        boss = false;
        description = "A rhino with its horn made of fire.";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new BodySlam());
        moveSet.Add(new Rest());
        holdItem = new Horn();// fix. also charcoal
        expToGive = 20;
        weakness = "ice";
        resistance = "fire";
        stats.CreateNewStats(70, 60, 30, 55, 25);
    }
}