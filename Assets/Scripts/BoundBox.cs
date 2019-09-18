using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundBox : MonoBehaviour {

    private BoxCollider2D bounds;
    private CameraController theCamera;

	// Use this for initialization
	void Start () {
        theCamera = FindObjectOfType<CameraController>();
        bounds = GetComponent<BoxCollider2D>();
        theCamera.SetBounds(bounds);
	}
}
