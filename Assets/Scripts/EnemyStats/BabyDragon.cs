using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDragon : Enemy
{
    // Use this for initialization
    void Start()
    {
		characterName = "Baby dragon"; 
		boss = false;
		description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Bite());
        //moveSet.Add(new ());

        holdItem = new DragonScale(); 
		expToGive = 10;
		weakness = "";
		resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
        //base_stats = {"energy": 60; "sp": 60; "power": 30; "defence": 55; "speed": 25; "accuracy": 100}
    }
}