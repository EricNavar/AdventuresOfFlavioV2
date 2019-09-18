using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private PlayerController thePlayer;
    private CameraController theCamera;
    public Vector2 startDirection;
    public string startString;

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerController>();

        //unsustainable code. fix later.
        /*
        if (thePlayer == null)
        {
            thePlayer = FindObjectOfType<CarController>();
        }
        */

        if (thePlayer.startPoint == startString)
        {
            thePlayer.transform.position = transform.position;
            thePlayer.setLastMove(startDirection);

            theCamera = FindObjectOfType<CameraController>();
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        }
	}
}
