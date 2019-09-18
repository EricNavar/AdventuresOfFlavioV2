using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorcerer : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Sorcerer";
        boss = true;
        description = "";
        ArrayList moveSet = new ArrayList();
        moveSet.Add(new ParticleBeam());
        //moveSet.Add(new Scratch());
        holdItem = new Wand();
        expToGive = 10;
        weakness = "";
        resistance = "";
        stats.CreateNewStats(60, 60, 30, 55, 25);
    }
}