using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is attatched to the player
public class HurtEnemy : MonoBehaviour {

    public int damageToGive;//How much damage a particular sword will give
    private int currentDamage;//the final calculated damage that will be given to an enemy.
    public GameObject damageBurst;
    public Transform hitPoint;
    public GameObject damageNumber;

    //private PlayerStats thePS;

	// Use this for initialization
	void Start () {
        //thePS = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            currentDamage = damageToGive = thePS.currentAttack;

            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(currentDamage);
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
            var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
        }
    }
    */
}
