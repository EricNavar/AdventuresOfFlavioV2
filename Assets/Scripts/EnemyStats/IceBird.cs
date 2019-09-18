using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBird : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "IceBird";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Fly());
        //moveSet.Add(new Slash());
        holdItem = new Feather();
        expToGive = 10;
        weakness = "fire";
        resistance = "ice";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}