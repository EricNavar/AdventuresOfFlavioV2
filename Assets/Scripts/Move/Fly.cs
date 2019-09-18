using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Fly : Move {
	
	//fly = move("fly", "Flies in the air and attacks one turn later", 60, element, type_, "foe", effect, sp, "delay")

	// Use this for initialization
	void Start () {
		moveName = "Fly";
		//The description you see in the character's profile
		description = "Flies in the air and attacks one turn later";
		//In battle, the move will cause this text to appear. 
		//battleText = ;
		type = null;
		baseAttack = 80;
		accuracy = .9f;
		priority = 0;
		sp = 10;
		targets = "foe";
		//does the move make contact with the enemy like a punch?
		contact = true;
		secondaryEffect = null;
		effectRate = 0f;
		recoil = 0f;
	}

    public new void UseMove(BattleInfo user)
    {
        Debug.Log(user.GetName() + "flew into the sky!");
        user.SetNextMove(new Fly2());
        //make sprite transparent
        SpriteRenderer playerSprite = BattleInfo.FindObjectOfType<SpriteRenderer>();
        playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
        //make impossible to hit
        user.SetCanChooseNextMove(false);
    }
}