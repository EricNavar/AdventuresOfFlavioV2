using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour {

    private Rigidbody2D myRigidbody;

    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        myRigidbody.velocity = Vector2.zero;
    }
}
