using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBubble : MonoBehaviour {

    private Animator anim;
    public float timeToAnimate;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        timeToAnimate -= Time.deltaTime;

        if (timeToAnimate <= 0)
        {
            anim.SetBool("isAnimating", false);
        }
    }
    /*
    public void DestroyBubble()
    {
        Destroy(gameObject);
    }
    */
}
