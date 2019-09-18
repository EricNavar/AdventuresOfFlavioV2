using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider healthbar;
    public Text HPText;
    public Text levelText;
    public Hero thePS;
    private static bool UIExists;
    

	// Use this for initialization
	void Start () {
        if (!UIExists)
        {
            UIExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        thePS = FindObjectOfType<Hero>();
        int currentLevel = thePS.currentLevel;
        int currentHP = thePS.GetStats().GetCurrentStat(0);
        int maxHP = thePS.GetStats().GetBaseStat(0);

        healthbar.maxValue = maxHP;
        healthbar.value = currentHP;
        HPText.text = "HP: " + currentHP + "/" + maxHP;
        levelText.text = "Lvl: " + currentLevel;
    }
	
    public void SetHealthBar(int newHealth)
    {
        healthbar.value = newHealth;
    }
}
