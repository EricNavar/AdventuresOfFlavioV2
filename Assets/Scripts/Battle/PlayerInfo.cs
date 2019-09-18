using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {

    public Slider healthBar;
    public Slider spBar;
    public Text playerName;

    public PlayerInfo(int hp, int sp, string name)
    {
        healthBar.value = hp;
        spBar.value = sp;
        playerName.text = name;
    }

    void SetHP(int hp)
    {
        healthBar.value = hp;
    }

    void SetSP(int sp)
    {
        healthBar.value = sp;
    }
}
