using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Skeleton";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();
        //moveSet.Add(new Rest());
        moveSet.Add(new Slash());
        holdItem = new Rib();//800 coins
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}