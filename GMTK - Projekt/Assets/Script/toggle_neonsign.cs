using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_neonsign : MonoBehaviour
{
    public DayNightCycle2D DayNightCycler;
    void Update()
    {
        if (DayNightCycler.getDaytime())
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
