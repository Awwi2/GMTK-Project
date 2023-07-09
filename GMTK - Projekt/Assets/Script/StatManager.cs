using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatManager : MonoBehaviour
{
    public static StatManager Instance;

    public int money;
    public int moneyPerPerson = 50;
    public int peopleToday;
    public int risk = 0;
    public int popularity = 10;
    public int rent = 200;

    Text[] Texts;
    private Text mon;
    private Text mPP;
    private Text pop;
    private Text r;
    private Text ren;

    public void FindUI()
    {
        Texts = GameObject.FindObjectsOfType<Text>();
        foreach (Text t in Texts)
        {
            if (t.name == "Money")
            {
                mon = t;
            }
            else if (t.name == "MoneyPerPerson")
            {
                mPP = t;
            }
            else if (t.name == "Popularity")
            {
                pop = t;
            }
            else if (t.name == "Risk")
            {
                r = t;
            }
            else if (t.name == "Rent")
            {
                ren = t;
            }
        }
    }

    private void Awake()
    {
        UpdateValues();
        Debug.Log("test");

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void executeDay()
    {
        FindUI();
        /*int i = 6;
        peopleToday = 0;
        while(Random.Range(1,i) <= popularity)
        {
            peopleToday += 1;
            i += 5;
        }
        */
        peopleToday = popularity / 5;
        money += moneyPerPerson * peopleToday;
        money -= rent;
        if(Random.Range(1,100) <= risk) //Getting Sued
        {
            money -= Random.Range(100, 1000);
            popularity -= Random.Range(10, 100);
            pop.text = popularity.ToString();
        }
        mon.text = money.ToString();
    }

    public void tempMPPPlus()
    {
        moneyPerPerson += 10;
        mPP.text = moneyPerPerson.ToString();
    }

    public void tempRiskPlus()
    {
        risk += 5;
        r.text = risk.ToString();
    }

    public void tempPopPlus()
    {
        popularity += 2;
        pop.text = popularity.ToString();
    }

    public void tempRentPlus()
    {
        rent += 50;
        ren.text = rent.ToString();
    }

    public void UpdateValues()
    {
        FindUI();

        Debug.Log(money);
        Debug.Log(mon);
        mon.text = money.ToString();
        mPP.text = moneyPerPerson.ToString();
        pop.text = popularity.ToString();
        r.text = risk.ToString();
        ren.text = rent.ToString();

    }
}
