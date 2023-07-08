using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDealer : MonoBehaviour
{
    private bool isSpawned;
    public DayNightCycle2D DayNightCycler;
    public GameObject dealer;

    void Update()
    {
        if (!DayNightCycler.getDaytime() && isSpawned == false)
        {
            isSpawned = true;
            Instantiate(dealer);
        } else if (DayNightCycler.getDaytime())
        {
            isSpawned = false;
        }
    }
}
