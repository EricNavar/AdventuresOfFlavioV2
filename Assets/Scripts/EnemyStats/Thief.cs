using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Thief";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Steal());
        //moveSet.Add(new Slash());
        holdItem = new GoldenNugget();//800 coins
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}