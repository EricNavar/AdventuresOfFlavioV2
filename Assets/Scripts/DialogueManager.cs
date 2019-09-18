using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    //this is public so it can be used for testing
    public bool dialogueActive;

    public string[] dialogLines;
    public int currentLine;

    private PlayerController thePlayer;

    private float sleepCounter = 0;
    public bool isSleeping = false;
    public float textLength;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}

    // Update is called once per frame
    void Update()
    {
        if (!isSleeping)
        {
            if (dialogueActive && Input.GetKeyDown(KeyCode.F))
            {
                currentLine++;
                //revealText();

                if (currentLine >= dialogLines.Length)
                {
                    dBox.SetActive(false);
                    dialogueActive = false;

                    currentLine = 0;
                    dText.text = dialogLines[currentLine];
                    thePlayer.canMove = true;
                    isSleeping = true;
                }
            }
            dText.text = dialogLines[currentLine];
            //revealText();
        }
        else
        {
            sleepCounter += Time.deltaTime;
            if (sleepCounter >= .1f)
            {
                isSleeping = false;
            }
        }
    }

    public void ShowBox(string dialogue)
    {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogue()
    {
        dialogueActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }

    private void revealText()
    {
        textLength += Time.deltaTime;
        dText.text = dialogLines[currentLine].Substring(0, (int)textLength * 3);
    }
}
