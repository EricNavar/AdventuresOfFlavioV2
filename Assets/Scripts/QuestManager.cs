using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

    public QuestObject[] quests;
    public bool[] questsCompleted;
    public DialogueManager theDM;
    public string itemCollected;//the Item that has last been collected
    public string enemyKilled;//the enemy that has last been killed

	// Use this for initialization
	void Start () {
        questsCompleted = new bool[quests.Length];
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowQuestText(string text)
    {
        theDM.dialogLines = new string[1] { text };
        theDM.currentLine = 0;
        theDM.ShowDialogue();

    }
}
