using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is attatched to the enemy.
public class Enemy : BattleInfo
{
    public bool boss;
    public int expToGive;
    public string description;
    private BattleManager battleMng;
    protected SpriteRenderer sprite;

    void Start()
    {
        battleMng = FindObjectOfType<BattleManager>();
    }

    public void DecideAttack()
    {
        List<Move> possibleMoves = new List<Move>();
        List<BattleInfo> possibleTargets = new List<BattleInfo>();
        
        foreach (Move move in moveSet)
        {
            if ( move.sp <= stats.GetCurrentStat(2) )
            {
                possibleMoves.Add(move);
            }
        }
        int num = Random.Range(0, 2);
        if (num == 0)
        {
            SetNextMove(new RegularAttack());
        }
        else
        {
            nextMove = possibleMoves[UnityEngine.Random.Range(0, possibleMoves.Count)];
        }
        if (nextMove.targets == "foe")
        {
            /*decide target. If target is foe, one of the following has a 1 in 3 chance of occuring: 
             * x = 1: weakest hero is attacked
             * x = 2: hero with status effect is attacked. If none have a status effect, the weakest is attacked.
             * x = 3: random hero is attacked. 
             * 
             */
            List<Hero> afflictedTargets = new List<Hero>(); //heroes with a status effect
            foreach (Hero hero in battleMng.theParty.GetMembers())
            {
                if (hero.GetStatus() != "dead")
                {
                    possibleTargets.Add(hero);
                    if (hero.GetStatus() != null)
                    {
                        afflictedTargets.Add(hero);
                    }
                }
            }
            int x = Random.Range(0, 2);
            if (x == 0)
            {

                SetNextTarget(new BattleInfo[] { possibleTargets[Random.Range(0, possibleTargets.Count)] });
            }
            else if (x == 1)

                if (afflictedTargets.Count > 1)
                {
                    SetNextTarget(new BattleInfo[] { afflictedTargets[Random.Range(0, afflictedTargets.Count)] });
                }
                else
                {
                    x = 2;
                }
            else
            {
                //Gets the weakest hero by percent of hp. If two tie, it's just the last one
                float weakestHeroPercent = 1.1f;
                float HPPercent;
                List<Hero> weakestHeroes = new List<Hero>();
                foreach (Hero hero in battleMng.theParty.GetMembers())
                {
                    HPPercent = hero.GetStats().getHPPercent();
                    if (HPPercent < weakestHeroPercent)
                    {
                        weakestHeroes.Add(hero);
                        weakestHeroPercent = HPPercent;
                    }
                }
                nextTarget = new BattleInfo[] { weakestHeroes[Random.Range(0, weakestHeroes.Count)] };
            }
        }

        else if (nextMove.targets == "ally")
        {
            foreach (Enemy enemy in battleMng.enemies)
            {
                if (enemy.name != characterName)
                {
                    possibleTargets.Add(enemy);
                }
            }
            //nextTarget= weakestHeroes[Random.Range(0, weakestHeroes.Length)];
        }
        else if (nextMove.targets == "all foes")
        {
            nextTarget = battleMng.theParty.GetMembers();
        }
        else if (nextMove.targets == "self")
        {
            nextTarget = new BattleInfo[] { this };
        }
        else if (nextMove.targets == "party")
        {
            nextTarget = battleMng.theParty.GetMembers();
        }
        else
        {
            Debug.Log("Debug. This should never print.");
        }
    }

    public override void Die()
    {
        
    }

}
