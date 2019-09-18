using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyController : MonoBehaviour {

    protected Rigidbody2D myRigidbody;

    public bool canMove;
    private bool isMoving;
    protected bool attacking;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;

    public float timeToMove;
    private float timeToMoveCounter;

    public float timeToAttack;
    private float timeToAttackCounter;

    private Vector3 moveDirection;
    protected Vector3 heading;

    private PlayerController thePlayer;

    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        myRigidbody = GetComponent<Rigidbody2D>();

        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.5f);
        timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.5f);
        timeToAttackCounter = timeToAttack;

        //thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    protected void Update()
    {
        if (attacking)
        {
            timeToAttackCounter -= Time.deltaTime;
            if (timeToAttackCounter < 0f)
            {
                attacking = false;
                isMoving = false;
                timeToAttackCounter = timeToAttack;
                timeBetweenMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.5f);
            }
        }
        else if (canMove)
        {
            if (attacking)
            {
                timeToAttackCounter -= Time.deltaTime;
                if (timeToAttackCounter < 0f)
                {
                    stopAttacking();
                }
            }

            //If in range, attack
            heading = thePlayer.transform.position - transform.position;
            if (heading.magnitude < 5f)
            {
                attacking = true;
                attack();
            }

            else
            {
                timeToMoveCounter -= Time.deltaTime;
                myRigidbody.velocity = moveDirection;

                if (timeToMoveCounter < 0f)
                {
                    //Stop moving
                    isMoving = false;
                    //timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.5f);
                    timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.5f);
                }
                else
                {
                    timeBetweenMoveCounter -= Time.deltaTime;
                    myRigidbody.velocity = Vector2.zero;

                    if (timeBetweenMoveCounter < 0f)
                    {
                        // Start moving again
                        isMoving = true;
                        //timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.5f);
                        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.5f);
                        moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
                    }
                }
            }  
        }
    }    

    public abstract void attack();
    public void stopAttacking()
    {
        attacking = false;
        isMoving = false;
        timeToAttackCounter = timeToAttack;
        timeBetweenMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.5f);
    }
}