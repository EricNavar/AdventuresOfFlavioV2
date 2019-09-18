using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour
{

    public string dialogue;
    private DialogueManager DManager;
    private bool inRange; //if Player is close enough to the dialogueHolder to speak to him
    public string[] dialogLines;
    //public DialogueBubble dialogueBubble;

    // Use this for initialization
    void Start()
    {
        DManager = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            if (!DManager.dialogueActive && !DManager.isSleeping)
            {
                DManager.dialogLines = dialogLines;
                DManager.currentLine = 0;
                DManager.ShowDialogue();
                //dialogueBubble.DestroyBubble();
            }

            if (transform.parent.GetComponent<NPCMovement>() != null)
            {
                transform.parent.GetComponent<NPCMovement>().canMove = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space");
                DManager.ShowBox(dialogue);
            }
        }
        */

        if (other.gameObject.name == "Player")
        {
            inRange = true;

            //dialogueBubble = Instantiate(dialogueBubble, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inRange = false;
        }
        //dialogueBubble.DestroyBubble();
    }
}