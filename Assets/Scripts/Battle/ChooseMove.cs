using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseMove : MonoBehaviour
{
    private Hero thePlayer;
    public bool flag = false;//flag false means the user has not finished choosing a move for this character.
    public Slider boost;
    public Button runButton;
    
    void Update()
    {
        if (flag)
        {
            this.enabled = false;
        }
    }

    public void Display(bool canEscape, int boostValue)
    {
        //Set value of Slider boost to the player's current boost value
        boost.value = boostValue;
        if (!canEscape)
        {
            runButton.enabled = false;
        }
    }

    public void UseBoost(Hero player)
    {
        player.GetStats().boosted = true;
        boost.value = 0;
    }

    public void Attack(Hero  player)
    {
        player.SetNextMove(new RegularAttack());
        //player.SetNextTarget(chooseTarget(player.GetNextMove()));
    }

    public void SetMove(Move move)
    {
        thePlayer.SetNextMove(move);
    }

    public void SetFlag(Boolean b)
    {
        flag = b;
    }
}