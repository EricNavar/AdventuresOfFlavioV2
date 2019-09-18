using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    //the gameObject with this script must start out inactive 

    public int questNumber;
    public QuestManager theQM;
    public string StartText;
    public string EndText;

    //public bool isItemQuest;
    //public string targetItem;

    //public bool isEnemyQuest;
    //public string targetEnemy;
    //public int enemiesToKill;
    //private int enemyKillCount = 0;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (isItemQuest)
        {
            if (theQM.itemCollected == targetItem)
            {
                theQM.itemCollected = null;
                EndQuest();
            }
        }
        */

        /*
        if (isEnemyQuest)
        {
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
        */
	}

    public void StartQuest()
    {
        theQM.ShowQuestText(StartText);
    }

    public void EndQuest()
    {
        theQM.ShowQuestText(EndText);
        theQM.questsCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
