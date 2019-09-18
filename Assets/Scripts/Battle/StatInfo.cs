using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatInfo : MonoBehaviour {
    enum StatType { hp, sp, attack, defence, speed, accuracy, evasiveness, boost };
    public bool boosted;
    public Stat[] stats = new Stat[8];
    //                                 -6     -5    -4    -3   -2   -1    0   1     2   3     4   5     6
    private float[] buffMultiplier = { .25f, .285f, .33f, .4f, .5f, .66f, 1f, 1.5f, 2f, 2.5f, 3f, 3.5f, 4f };


    public class Stat
    {
        public int buffs;
        public int baseValue;
        public int currentValue;
        
        public void RevertStat()
        {
            buffs = 0;
            currentValue = baseValue;
        }

        public Stat(int num)
        {
            baseValue = num;
            currentValue = num;
            buffs = 0;
        }
    }

    public void CreateNewStats(int hp, int sp, int attack, int defence, int speed)
    {
        stats[0] = new Stat(hp);
        stats[1] = new Stat(sp);
        stats[2] = new Stat(attack);
        stats[3] = new Stat(defence);
        stats[4] = new Stat(speed);
        stats[5] = new Stat(100);
        stats[6] = new Stat(0);
        stats[7] = new Stat(0);
    }

    //returns true if successful. false if cannot bugg/debuff anymore
    public bool AddBuff(int stat, int amount)
    {
        stats[stat].buffs += amount;
        if (amount > 6)
        {
            stats[stat].buffs = 6;
            return false;
        }
        else if (amount < -6)
        {
            amount = 6;
            return false;
        }
        stats[stat].currentValue = (int)(stats[stat].baseValue * buffMultiplier[stats[stat].buffs + 6]);
        return true;
    }

    public void ChangeCurrentStat(int statNum, int amount)
    {
        stats[statNum].currentValue += amount;
    }

    public void removeBuffInfo(int statNum)
    {
        stats[statNum].buffs = 0;
        stats[statNum].currentValue = stats[statNum].baseValue;
    }

    //Use for after battle to remove all buffs. HP, SP, and Boost do not get buffs right now.
    public void RevertAllStats()
    {
        for (int i = 2; i < 8; i++)
        {
            stats[i].RevertStat();
        }
    }

    public float getHPPercent()
    {
        return stats[0].currentValue / stats[0].baseValue;
    }

    public void LevelUp()
    {
        for (int i = 0; i < 7; i++)
        {
            stats[i].baseValue += 4;
        }
        stats[0].currentValue += 4;
    }

    //adds amount to current Stat. Returns false if dead.
    public bool ChangeHP(int amount)
    {
        stats[(int)StatType.hp].currentValue += amount;
        if (stats[(int)StatType.hp].currentValue > 0)
        {
            SetCurrentStat(0, GetBaseStat(0));
            return false;
        }
        if (stats[(int)StatType.hp].currentValue > stats[(int)StatType.hp].currentValue)
        {
            SetCurrentStat(0, GetBaseStat(0));
        }
        return true;
    }

    //for if you have a potion or move that restores a certain percent of the base stats. 
    public void ChangeHP(float amount)
    {
        
    }

    public void SetCurrentStat(int i, int amount)
    {   stats[i].currentValue = amount; }

    public int GetBaseStat(int i)
    {   return stats[i].baseValue; }

    public int GetCurrentStat(int i)
    { return stats[i].currentValue; }

    public void displayBuffInfo()
    {
        string str = "";
        foreach (Stat stat in stats)
        {
            str += (buffMultiplier[stat.buffs] * 100).ToString() + "%";
        }
    }
    
    public void AddToBaseStat(int stat, int increment)
    {
        stats[stat].baseValue += increment;
        stats[stat].currentValue += increment;
    }
    
}