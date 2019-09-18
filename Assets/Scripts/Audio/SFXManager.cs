using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

    public AudioSource playerHurt;
    public AudioSource playerDead;
    public AudioSource playerAttack;

    public bool SFXManExists;

	// Use this for initialization
	void Start () {
        if (!SFXManExists)
        {
            SFXManExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
