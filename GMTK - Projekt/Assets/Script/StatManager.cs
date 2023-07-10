using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatManager : MonoBehaviour
{
    public static StatManager Instance;

    public int money;
    private int standartMoney;
    [Min(0)]
    public int moneyPerPerson = 50;
    private int standartMoneyPerPerson;
    [Min(0)]
    public int peopleToday;
    [Min(0)]
    public int risk = 0;
    private int standartRisk;
    [Min(0)]
    public int popularity = 10;
    private int standartPopularity;
    [Min(0)]
    public int rent = 200;
    private int standartRent;
    [Min(0)]
    public int day = 0;
    private int standartDay;
    public bool neonSign;
    public int sueMoney = 1000;
    public int suePop = 10;

    Text[] Texts;
    private Text mon;
    private Text mPP;
    private Text pop;
    private Text r;
    private Text ren;
    private Text d;
    private GameObject sue;

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
            else if (t.name == "Days")
            {
                d = t;
            }
        }
    }
    private void Update()
    {
        if (moneyPerPerson < 0)
        {
            moneyPerPerson = 0;
        } else if (peopleToday < 0)
        {
            peopleToday = 0;
        }
        else if (risk < 0)
        {
            risk = 0;
        }
        else if (popularity < 0)
        {
            popularity = 0;
        }
        else if (rent < 0)
        {
            rent = 0;
        }
    }

    private void Awake()
    {

        standartMoney = money;
        standartMoneyPerPerson = moneyPerPerson;
        standartRisk = risk;
        standartPopularity = popularity;
        standartRent = rent;
        standartDay = day;

        UpdateValues();

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void addMoney()
    {
        money += moneyPerPerson;
        UpdateValues();
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
        sue = GameObject.Find("Sued");
        day += 1;
        if(day % 5 == 0)
        {
            rent += 50;
            sueMoney += 200;
            suePop += 10;
        }
        money -= rent;
        if(Random.Range(1,100) <= risk) //Getting Sued
        {
            money -= Random.Range(sueMoney, risk * sueMoney + 1);
            popularity -= Random.Range(suePop, risk * suePop + 1);
            pop.text = popularity.ToString();
            sue.GetComponent<Animator>().Play("YouGotSued");
        }
        UpdateValues();

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

        mon.text = money.ToString();
        mPP.text = moneyPerPerson.ToString();
        pop.text = popularity.ToString();
        r.text = risk.ToString();
        ren.text = rent.ToString();
        d.text = day.ToString();


    }
    public void ResetValues()
    {
        money = standartMoney;
        moneyPerPerson = standartMoneyPerPerson;
        risk = standartRisk;
        popularity = standartPopularity;
        rent = standartRent;
        day = standartDay;
    }
}
