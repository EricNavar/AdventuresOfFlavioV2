using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puppy : Enemy
{
    // Use this for initialization
    void Start()
    {
        characterName = "Puppy";
        boss = false;
        description = "The cutest puppy you have ever seen. It spreads joy to everyone it encounters and should never be harmed ever.";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Bite());
        moveSet.Add(new Scratch());
        moveSet.Add(new Howl());

        holdItem = new PuppySkull();
        expToGive = -100;
        //weakness = ["fire", "ice", "dark", "volt", "water"]
        weakness = "";
        resistance = "";
        //base_stats = {"energy": 9000, "sp": 40, "power": 1, "defence": 5, "speed": 20, "accuracy": 100}
        stats.CreateNewStats(9000, 60, 1, 55, 25);
    }
}