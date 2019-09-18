using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Enemy
{
    private void Start()
    {
        characterName = "Bear";
        boss = false;
        description = "";

        ArrayList moveSet = new ArrayList();
        moveSet.Add(new Rest());
        moveSet.Add(new Slash());

        holdItem = new HoneyNutCheerios();
        expToGive = 10;
        weakness = null;
        resistance = null;
        stats.CreateNewStats(60, 60, 30, 55, 25);
        sprite = Resources.Load("Assets/Art/slime_red") as SpriteRenderer;
    }
}