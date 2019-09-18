using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum StatType { hp, sp, attack, defence, speed, accuracy, evasiveness, boost };

public abstract class BattleInfo : MonoBehaviour
{
    protected bool canChooseNextMove = true;
    protected string status;
    protected string resistance;
    protected string weakness;
    protected string characterName;
    protected StatInfo stats;
    protected List<Move> moveSet = new List<Move>();
    protected InventoryItem holdItem;
    protected BattleInfo[] nextTarget;
    protected Move nextMove;

    private void Start()
    {
        //StatInfo = gameObject.AddComponent<Stats>() as Stats;
    }

    public abstract void Die();    

    public int CalculateDamage(BattleInfo user, BattleInfo target)
    {
        float modifier = 1f;
        if (target.weakness == user.nextMove.type)
        {
            modifier *= 2f;
        }
        if (target.resistance == user.nextMove.type)
        {
            modifier *= .5f;
        }
        int a = (int)StatType.defence;
        int damage = (int)Mathf.Ceil(user.nextMove.baseAttack * stats.GetCurrentStat(a) 
            * modifier / target.stats.GetCurrentStat(4));

        //1 in 5 chance of getting a critical hit 
        if (UnityEngine.Random.Range(0, 5) == 0)
        {
            damage *= 2;
            Debug.Log("Critical Hit!");
            //user.theBattle.Canvas.Text = "Critical hit!";
        }
        return damage;
    }

    //use when player completely heals
    public void RevertAllStats()
    {
        RevertBattleInfo();
        
    }

    //use after a battle ends
    public void RevertBattleInfo()
    {
        nextMove = null;
        nextTarget = null;
    }
    public void Attack()//fix. Will this move be a part of battlemanager or StatHolder? 
    {
        stats.SetCurrentStat(2, -nextMove.sp);
        //Move move = StatInfo.GetNextMove();

        //Calculate the damage foreach target in array NextTarget
        foreach (BattleInfo target in nextTarget)
        {
            nextMove.UseMove(target);
        }
        //fix. placerholder
    }

    public void SetStatus(string newStatus)
    {   status = newStatus; }

    public BattleInfo[] GetNextTargets()
    {   return nextTarget; }

    public Move GetNextMove()
    { return nextMove; }

    public string GetStatus()
    {   return status; }

    public string GetWeakness()
    { return weakness; }

    public string GetResistance()
    { return resistance; }

    public void SetNextTarget(BattleInfo[] newTarget)
    {   nextTarget = newTarget; }

    public void SetNextMove(Move newMove)
    { nextMove = newMove; }

    public string GetName()
    { return characterName; }

    public StatInfo GetStats()
    { return stats; }

    public InventoryItem GetHoldItem()
    { return holdItem; }

    public List<Move> GetMoveSet()
    { return moveSet; }

    public void SetCanChooseNextMove(bool b)
    { canChooseNextMove = b; }
}