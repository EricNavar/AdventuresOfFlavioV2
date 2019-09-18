using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterVehicle : MonoBehaviour {

    private bool inRange;
    //the thing that the player controls before entering the vehicle
    public GameObject currentPlayer;
    //private SpriteRenderer playerSprite;
    private CameraController theCamera;

	// Use this for initialization
	void Start () {
        theCamera = FindObjectOfType<CameraController>();
        //playerSprite = currentPlayer.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            currentPlayer.gameObject.SetActive(false);
            //playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            theCamera.followTarget = transform.parent.gameObject;
            transform.parent.GetComponent<CarController>().canMove = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inRange = false;
        }
    }
}
