using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMacaw : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Fire Macaw";
        boss = true;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Fly());

        holdItem = new Carminite();
        expToGive = 10;
        weakness = "ice";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}