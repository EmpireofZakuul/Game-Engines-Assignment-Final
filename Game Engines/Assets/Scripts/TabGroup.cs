using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public Color Idle;
    public Color Hover;
    public Color Active;
    public TabButton selectedTab;
    public List<GameObject> SwapObjects;


    public void MenuButtons(TabButton button)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        tabButtons.Add(button);
    }

    public void TabEnter(TabButton button)
    {
        TabReset();
        if(selectedTab == null || button != selectedTab)
        {
            button.background.color = Hover;
        }
       
    }

    public void TabExit(TabButton button)
    {
        TabReset();
    }

    public void TabSelected(TabButton button)
    {
        if( selectedTab != null)
        {
            selectedTab.Deselect();
        }
        selectedTab = button;

        selectedTab.Select();

        TabReset();
        button.background.color = Active;
        int index = button.transform.GetSiblingIndex();
        for(int i=0; i<SwapObjects.Count; i++)
        {
            if(i == index)
            {
                SwapObjects[i].SetActive(true);
            }
            else
            {
                SwapObjects[i].SetActive(false);
            }
        }
    }

    public void TabReset()
    {
        foreach(TabButton button in tabButtons)
        {
            if(selectedTab!= null && button == selectedTab) { continue; }
            button.background.color = Idle;
        }
    }

    //public void Update()
    //{
        //if (Input.GetKeyDown(KeyCode.Q))
       // {
           // if(selectedTab.transform.GetSiblingIndex() > 0)
           // {
              //  SetActive(Active.transform.SetSiblingIndex() - 1);

           // }
        //}
    //}
}
