using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormDragon : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Storm Dragon";
        boss = true;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new FrigidSlash());
        moveSet.Add(new FlameGrater());
        moveSet.Add(new Flamethrower());
        moveSet.Add(new IceBeam());

        holdItem = new ExtinguishedIce();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}