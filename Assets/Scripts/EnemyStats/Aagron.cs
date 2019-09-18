using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aagron : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Aagron";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new HeadBash());
        //moveSet.Add(new Scratch());
        holdItem = new Horn();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}