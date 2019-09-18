using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    //private PlayerController thePlayer;

    public float moveSpeed;
    private float currentMoveSpeed;

    private Animator anim;
    private Rigidbody2D myRigidbody;

    private Vector2 moveInput;

    private static bool playerExists;

    public bool canMove = false;

    public float x;
    public float y;

    // Use this for initialization
    void Start()
    {
        //thePlayer = FindObjectOfType<PlayerController>();
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;
        }

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (moveInput != Vector2.zero)
        {
            myRigidbody.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
        }
        else
        {
            myRigidbody.velocity = Vector2.zero;
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        //thePlayer.transform.position = transform.position;
        x = myRigidbody.velocity.x;
        y = myRigidbody.velocity.y;
    }

}
