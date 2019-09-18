using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularAttack : Move {

	void Start () {

    moveName = "Attack";
    //description = "A regular attack";
    type = null;
    baseAttack = 50;
    accuracy = .95f;
    priority = 0;
    sp = 0;
    targets = "foe";
    contact = true;
    secondaryEffect = null;
    effectRate = 0f;
    }
    
}
