using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemQuest : QuestObject
{

    public string targetItem;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (theQM.itemCollected == targetItem)
        {
            theQM.itemCollected = null;
            EndQuest();
        }
    }
}
