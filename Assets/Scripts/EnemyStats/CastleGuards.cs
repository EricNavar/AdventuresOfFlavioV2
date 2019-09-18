using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleGuards : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Castle guards";
        boss = false;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Stab());
        
        holdItem = new LeatherScrap();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}