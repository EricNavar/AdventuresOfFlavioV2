using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour {


    public float moveSpeed;
    private Rigidbody2D myRigidbody;

    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;

    private bool isWalking;

    public float walkTime;
    private float walkCounter;

    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkZone;

    private bool hasWalkZone;

    public bool canMove;
    private DialogueManager theDM;


    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        theDM = FindObjectOfType<DialogueManager>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        chooseDirection();

        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (!theDM.dialogueActive)
        {
            canMove = true;
        }

        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;//get rid of this and add else before the next if statement
        }

        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (walkDirection)
            {
                case 0://moving up
                    if(hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    else
                    {
                        myRigidbody.velocity = new Vector2(0, moveSpeed);
                    }
                    break;
                case 1://moving right
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    else
                    {
                        myRigidbody.velocity = new Vector2(moveSpeed,0);
                    }
                    break;
                case 2://moving down
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    else
                    {
                        myRigidbody.velocity = new Vector2(0, -moveSpeed);
                    }
                    break;
                case 3://moving left
                    if (hasWalkZone && transform.position.x < minWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    else
                    {
                        myRigidbody.velocity = new Vector2(-moveSpeed, 0);
                    }
                    break;

            }


            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        }
        else
        {
            myRigidbody.velocity = Vector2.zero;

            waitCounter -= Time.deltaTime;

            if (waitCounter < 0)
            {
                chooseDirection();
            }
        }
	}

    public void chooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
