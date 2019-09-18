using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirate : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Pirate";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        //moveSet.Add(new Rest());
        moveSet.Add(new FireFormula());

        holdItem = new GoldenNugget();
        expToGive = 10;
        weakness = "water";// fix. and also dark
        resistance = "fire";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }

}