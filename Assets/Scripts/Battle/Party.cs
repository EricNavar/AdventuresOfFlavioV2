using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Attatched to Canvas
public class Party : MonoBehaviour
{
    private Hero[] members;
    private List<InventoryItem> inventory;
    private List<InventoryItem> keyItems;
    private int money;
    private int totalEnemiesKilled;

    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public Party(Hero[] members, List<InventoryItem> inventory, int money)
    {
        this.members = members;
        this.inventory = inventory;
        this.money = money;
    }

    public Hero GetPlayer(int num)
    {
        return members[num];
    }

    public bool IsOneAlive (int amount)//Is at least one member alive?
    {
        bool alive = false;
        foreach (BattleInfo hero in members)
        {
            if (hero.GetStats().GetCurrentStat(0) > 0)
            {
                alive = true;
            }
        }
        return alive;
    }

    public void ChangeMoney(int change)//Only for players
    {
        money += change;
        if (change > 0)
        {
            Debug.Log("You gained" + change + "coins.");
        }

        if (money < 0)
        {
            int amountLost = -change + money;
            Debug.Log("You lost" + amountLost + "coins.");
            money = 0;
        }
    }

    public Hero[] GetMembers()
    {
        return members;
    }

    public void AddToInventory(InventoryItem item)
    {

    }

    public bool InventoryContains(string match)
    {
        foreach (InventoryItem item in inventory)
        {
            if (item.itemName == match)
            {
                return true;
            }
        }
        return false;
    }

    public List<InventoryItem> GetInventory()
    {
        return inventory;
    }
}