using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningMcQueen : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Lightning McQueen";
        boss = true;
        description = "";
        ArrayList moveSet = new ArrayList();
        //moveSet.Add(new Rest());
        moveSet.Add(new Shoot());
        holdItem = new Cars2DVD();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}