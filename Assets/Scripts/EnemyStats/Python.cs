using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Python : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "T-Rex";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Bite());
        moveSet.Add(new PoisonShot());

        holdItem = new SnakeSkin();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}