using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is attatched to the enemy.
public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;
    private Hero thePlayer;
    public int expToGive;

    public string EnemyName;//this is just the name of the enemy
    private QuestManager theQM;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;
        thePlayer = FindObjectOfType<Hero>();
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            theQM.enemyKilled = EnemyName;
            Destroy(gameObject);
            thePlayer.addExperience(expToGive);
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void setMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
