using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour
{
    public ChooseMove moveChooser;
    private PlayerInfo[] playerInfos;
    public Text battleText;
    public BattleList list;

    //GameObject playerInfoPanel;

    private void Start()
    {
        moveChooser = FindObjectOfType<ChooseMove>();
    }

    public void SetParty(Party theParty)
    {
        for (int i = 0; i < theParty.GetMembers().Length; i++)
        {
            GameObject playerInfo = new GameObject("Player info " + i.ToString());
            playerInfo = (GameObject)Resources.Load("BattlePlayerInfo");

            //var clone = (GameObject)Instantiate(playerInfoPanel, new Vector2(0,0), Quaternion.Euler(Vector3.zero));
        }

        list.SetInventory(theParty.GetInventory());
    }

    //0 for skills, 1 for inventory
    public void DisplayBattleList(int n)
    {
        if (n == 0)
        {
            list.DisplaySkills();
        }
        else //if (n == 1)
        {
            list.DisplayInventory();
        }
    }

}