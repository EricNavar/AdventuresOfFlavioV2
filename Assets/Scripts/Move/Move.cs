using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Move : MonoBehaviour {

    public string moveName;
    //The description you see in the character's profile
    public string description;
    //In battle, the move will cause this text to appear. 
    public string type;
    public int baseAttack;
    public float accuracy;
    public int priority;
    public int sp;
    public string targets;
    //does the move make contact with the enemy like a punch?
    public bool contact;
    public string secondaryEffect;
    public float effectRate;
    public float recoil;
    private BattleManager theBattle;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UseMove(BattleInfo user)
    {
        theBattle = FindObjectOfType<BattleManager>();
        BattleInfo[] targets = ConfirmTargets(user);

        float prob;// probability that the move will land.
        int damageToTake = 0;
        bool living;

        foreach (BattleInfo target in targets)
        {
            //probability that move will hit
            prob = user.GetStats().GetCurrentStat(6) * accuracy / target.GetStats().GetCurrentStat(7);
            if (Random.Range(0,1) > prob)
            {
                damageToTake = user.CalculateDamage(user, target);
                living = target.GetStats().ChangeHP(-damageToTake);
                Debug.Log(target.GetName() + " lost " + damageToTake + " HP!");//Fix
                if (!living && target.GetType() == typeof(Enemy))
                {
                    theBattle.AddToTotalExp( ((Enemy)target).expToGive );
                    //target.Die();
                }
                else if (Random.Range(0, 1) < effectRate)
                {
                    //Fix
                }
            }
        }
        if (recoil > 0f)
        {
            user.GetStats().ChangeHP((int)(-damageToTake * recoil));
            Debug.Log(user.GetName() + " took recoil damage!");//Fix
        }

    }

    //if the user chose a single target and it's now dead, choose another random target 
    public BattleInfo[] ConfirmTargets(BattleInfo user)
    {
        BattleInfo[] targets = user.GetNextTargets();
        if (targets.Length == 1)
        {
            if (targets[0] == null)
            {
                return new BattleInfo[] { theBattle.enemies[0] };
            }
        }
        return targets;
    }

}
