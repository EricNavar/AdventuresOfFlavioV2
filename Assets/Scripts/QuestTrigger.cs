using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {

    private QuestManager theQM;

    public int QuestNumber;

    public bool startQuest = false;

	// Use this for initialization
	void Start () {
        theQM = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && !theQM.questsCompleted[QuestNumber])
        {
            //starts quest
            if (startQuest && !theQM.quests[QuestNumber].gameObject.activeSelf)
            {
                theQM.quests[QuestNumber].gameObject.SetActive(true);
                theQM.quests[QuestNumber].StartQuest();
            }
            //ends quest
            else if (!startQuest && theQM.quests[QuestNumber].gameObject.activeSelf)
            {
                theQM.quests[QuestNumber].EndQuest();
            }
        }
    }
}
