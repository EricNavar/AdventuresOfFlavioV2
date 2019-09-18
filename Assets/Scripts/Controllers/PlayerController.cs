using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController: MonoBehaviour {

    Party theParty;

    public float moveSpeed;
    private float currentMoveSpeed;

    private Animator anim;
    private Rigidbody2D myRigidbody;

    private bool playerMoving;
    private Vector2 lastMove;
    private Vector2 moveInput;

    private static bool playerExists;

    private bool attacking;
    public float attackTime;
    private float attackTimeCounter;

    public string startPoint;

    public bool canMove;

    private SFXManager sfxMan;

    // Use this for initialization
    void Start ()
    {
        List<InventoryItem> inventory = new List<InventoryItem>();
        inventory.Add(new Cake());

        GameObject go = new GameObject("Party");
        theParty = go.AddComponent<Party>();
        Hero[] partyMembers = { GetComponent<Hero>() };
        theParty = new Party(partyMembers, inventory, 500);

        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        sfxMan = FindObjectOfType<SFXManager>();

        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        canMove = true;

        lastMove = new Vector2(0, -1f);
	}
	
	// Update is called once per frame
	void Update () {

        playerMoving = false;

        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;
        }

        if (!attacking)
        {

            /*if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * currentMoveSpeed, myRigidbody.velocity.y);
                //add deltatime to the above code?
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }
            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * currentMoveSpeed);
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }

            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }
            */

            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

            if (moveInput != Vector2.zero)
            {
                myRigidbody.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
                playerMoving = true;
                lastMove = moveInput;
            }
            else
            {
                myRigidbody.velocity = Vector2.zero;
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                attackTimeCounter = attackTime;
                attacking = true;
                myRigidbody.velocity = Vector2.zero;
                anim.SetBool("Attack", true);

                sfxMan.playerAttack.Play();
            }

            /*if (Mathf.Abs (Input.GetAxisRaw("Horizontal")) > .05f && Mathf.Abs (Input.GetAxisRaw("Vertical")) > .05f)
            {
                currentMoveSpeed = moveSpeed * .707f;
            }
            else
            {
                currentMoveSpeed = moveSpeed;
            }
            */

        }

        if (attackTimeCounter > 0)
        {
            attackTimeCounter -= Time.deltaTime;
        }

        if (attackTimeCounter <= 0)
        {
            attacking = false;
            anim.SetBool("Attack", false);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }

    public void setLastMove(Vector2 direction)
    {
        lastMove = direction;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        Debug.Log(enemy.GetType());
        if ( enemy != null )
        {
            other.GetComponent<Collider2D>().enabled = false;
            GameObject go = new GameObject("Battle");

            //I load the scene here and in the battlemanagertest constructor but it doesn't work if i take it away here
            BattleManagerTest BMan = go.AddComponent<BattleManagerTest>();
            SceneManager.LoadScene("battle");
            //https://answers.unity.com/questions/964518/passing-arguments-into-a-constructor-via-addcompon.html
            Debug.Log("Touched enemy. Should be starting battle now.");
        }
    }
}
