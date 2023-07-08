using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public int money = 1000;
    public int moneyPerPerson = 50;
    public int peopleToday;
    public int risk = 0;
    public int popularity = 10;
    public int rent = 200;

    public Text mon, mPP, r, pop, ren;

    public void executeDay()
    {
        int i = 6;
        peopleToday = 0;
        while(Random.Range(1,i) <= popularity)
        {
            peopleToday += 1;
            i += 5;
        }
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
        mon.text = "Money: " + money;
        mPP.text = "Money Per Person: " + moneyPerPerson;
        pop.text = "Popularity: " + popularity;
        r.text = "Risk: " + risk;
        ren.text = "Rent: " + rent;

    }
}
