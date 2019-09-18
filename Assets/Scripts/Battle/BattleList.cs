using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleList : MonoBehaviour
{
    enum ActiveList{ Skills, Inventory, None };

    //the next 3 variables are updated for each new player
    private ActiveList activeList;
    private List<Move> moveSet;
    private int currentSP;

    private List<InventoryItem> inventory;
    private int listCount;//length of active list
    private int topIndex;

    Button[] buttons;
    TextMeshPro[] buttonTexts;

    // generate a group of connected GameObjects
    void Awake()
    {
        GameObject go = new GameObject("top");

        Random.InitState(System.Environment.TickCount);

        // add 3, 4 or 5 "middle" children that report to "top"
        for (int i = 0; i < Random.Range(3, 6); i++)
        {
            GameObject go2 = new GameObject("middle" + i.ToString());
            go2.transform.parent = go.transform;

            // add between 1 to 8 "bottom" children that report to the above "middle"
            for (int j = 0; j < Random.Range(1, 8); j++)
            {
                GameObject go3 = new GameObject("bottom" + j);
                go3.transform.parent = go2.transform;
            }
        }
    }

    void Start()
    {
        // how many children does top have?
        GameObject go = GameObject.Find("top");
        //Debug.Log(go.name + " has " + go.transform.childCount + " children");

        // pick a random middle group and pick a member of its children
        go = GameObject.Find("middle" + Random.Range(0, go.transform.childCount));
        //Debug.Log(go.name + " has " + go.transform.childCount + " children");
    }

    private void Update()
    {
        //if player cancels while inventory or skills list is up
        if (Input.GetKeyDown(KeyCode.S))
        {
            activeList = ActiveList.None;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GoUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GoDown();
        }
    }

    public void DisplaySkills()
    {
        gameObject.SetActive(true);

        topIndex = 0;
        for (int i = 0; i < 5; i++)
        {
            buttonTexts[i + 1].text = moveSet[i].moveName;
            if (currentSP < moveSet[i].sp)
            {
                buttons[i + 1].enabled = false;
            }
            else
            {
                buttons[i + 1].enabled = true;
            }
        }
    }

    public void DisplayInventory()
    {
        topIndex = 0;
        for (int i = 0; i < 5; i++)
        {
            buttonTexts[i].text = moveSet[i].moveName;
            buttons[i].enabled = true;
        }
    }

    public void GoUp()
    {
        if (activeList == ActiveList.Skills)
        {
            listCount = moveSet.Count;
        }
        else if (activeList == ActiveList.Inventory)
        {
            listCount = inventory.Count;
        }
        if (topIndex < 0)
        {
            topIndex--;
        }
        if (topIndex == 0)
        {
            //up button enabled
            buttons[0].enabled = false;
        }
        if (topIndex + 5 < listCount)
        {
            //down button enabled
            buttons[buttons.Length - 1].enabled = true;
        }
    }

    public void GoDown()
    {
        if (activeList == ActiveList.Skills)
        {
            listCount = moveSet.Count;
        }
        else if (activeList == ActiveList.Inventory)
        {
            listCount = inventory.Count;
        }
        if (topIndex < listCount - 1)
        {
            topIndex++;
        }
        if (topIndex == listCount - 1)
        {
            buttons[buttons.Length - 1].enabled = false;
        }
        if (topIndex + 5 < listCount)
        {
            buttons[0].enabled = true;
        }
    }

    //all players have the same inventory so just give BattleList class access to it at the start of the battle
    public void SetInventory(List<InventoryItem> items)
    {
        inventory = items;
    }

    //set this at the start of the player's turn
    public void UpdateOptions(List<Move> moves, int sp)
    {
        moveSet = moves;
        currentSP = sp;
        activeList = ActiveList.None;
    }
}