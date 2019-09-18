using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameMonster : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Flame monster";
        boss = false;
        description = "A flame monster is a fiery beast with a rocky body and a head and four legs made of fire. He can spit out lava.";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Flamethrower());
        moveSet.Add(new InfernoFormula());

        holdItem = new SuperPotion();
        expToGive = 250;
        weakness = "ice";
        resistance = "fire";
        stats.CreateNewStats(60, 60, 30, 55, 25);
        //base_stats = {"energy": 60; "sp": 60; "power": 30; "defence": 55; "speed": 25; "accuracy": 100}
    }
}