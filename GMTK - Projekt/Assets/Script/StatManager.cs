using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatManager : MonoBehaviour
{
    public static StatManager Instance;

    public int money = 1000;
    public int moneyPerPerson = 50;
    public int peopleToday;
    public int risk = 0;
    public int popularity = 10;
    public int rent = 200;

    Text[] Texts;
    public Text mon;
    public Text mPP;
    public Text pop;
    public Text r;
    public Text ren;

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
        if(Random.Range(1,100) <= risk)
        {
            money -= Random.Range(100, 1000);
            popularity -= Random.Range(10, 100);
            pop.text = "Popularity: " + popularity;
        }
        mon.text = "Money: " + money;
    }

    public void tempMPPPlus()
    {
        moneyPerPerson += 10;
        mPP.text = "Money Per Person: " + moneyPerPerson;
    }

    public void tempRiskPlus()
    {
        risk += 5;
        r.text = "Risk: " + risk;
    }

    public void tempPopPlus()
    {
        popularity += 2;
        pop.text = "Popularity: " + popularity;
    }

    public void tempRentPlus()
    {
        rent += 50;
        ren.text = "Rent: " + rent;
    }

    public void UpdateValues()
    {
        FindUI();

        mon.text = "Money: " + money;
        mPP.text = "Money Per Person: " + moneyPerPerson;
        pop.text = "Popularity: " + popularity;
        r.text = "Risk: " + risk;
        ren.text = "Rent: " + rent;

    }
}
