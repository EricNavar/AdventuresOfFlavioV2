using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magician : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Magician";
        boss = true;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Minimize());
        moveSet.Add(new ParticleBeam());

        holdItem = new CrystalStaff();
        expToGive = 10;
        weakness = "dark";// fix. and also dark
        resistance = "fire";
        stats.CreateNewStats(35, 20, 10, 25, 5);
    }
}