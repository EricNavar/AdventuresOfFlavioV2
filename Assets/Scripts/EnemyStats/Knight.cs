using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Knight";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Stab());
        moveSet.Add(new Slash());
        moveSet.Add(new DrawingStance());

        holdItem = new Helmet();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}