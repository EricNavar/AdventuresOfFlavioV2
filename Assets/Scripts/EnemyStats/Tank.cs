using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Enemy
{
    // Use this for initialization
    void Start()
    {
		characterName = "Tank"; 
		boss = true;
		description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Shoot());
        moveSet.Add(new ParticleBeam());

        holdItem = new Missile(); 
		expToGive = 10;
		weakness = "volt";
		resistance = "water";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}