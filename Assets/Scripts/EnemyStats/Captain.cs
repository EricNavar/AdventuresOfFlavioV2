using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Captain : Enemy
{
    // Use this for initialization
    void Start()
    {
		characterName = "Captain"; 
		boss = false;
		description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Slash());
        //moveSet.Add(new Slash());

        holdItem = new DragonScale(); 
		expToGive = 10;
		weakness = "";
		resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
        //base_stats = {"energy": 60; "sp": 60; "power": 30; "defence": 55; "speed": 25; "accuracy": 100}
    }
}