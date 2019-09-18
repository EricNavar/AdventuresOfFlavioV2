using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Bee";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Bite());
        //moveSet.Add(new Slash());

        holdItem = new MagicWings();
        expToGive = 10;
        weakness = null;
        resistance = null;
        stats.CreateNewStats(60, 60, 30, 55, 25);
        //base_stats = {"energy": 60; "sp": 60; "power": 30; "defence": 55; "speed": 25; "accuracy": 100}
    }
}