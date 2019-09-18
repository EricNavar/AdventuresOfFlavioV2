using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaSerpent : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Sea serpent";
        boss = true;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Dive());
        moveSet.Add(new WaterCannon());
        holdItem = new SeaScale();
        expToGive = 10;
        weakness = "volt";
        resistance = null;
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}