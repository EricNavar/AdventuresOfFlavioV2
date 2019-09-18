using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyQuest : QuestObject
{

    public string targetEnemy;
    public int enemiesToKill;
    private int enemyKillCount = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (theQM.enemyKilled == targetEnemy)
        {
            theQM.enemyKilled = null;

            enemyKillCount++;
            if (enemyKillCount >= enemiesToKill)
            {
                EndQuest();
            }
        }
    }
}
