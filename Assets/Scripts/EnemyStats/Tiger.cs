using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Tiger";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Bite());
        moveSet.Add(new Scratch());

        holdItem = new Fang();// fix. also charcoal
        expToGive = 20;
        weakness = null;
        resistance = "volt";
        stats.CreateNewStats(70, 60, 30, 55, 25);
    }
}