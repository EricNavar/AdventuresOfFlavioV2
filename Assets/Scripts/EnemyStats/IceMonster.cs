using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMonster : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "T-Rex";
        boss = true;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Bite());
        moveSet.Add(new BlizzardFormula());
        holdItem = new LargeTooth();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}