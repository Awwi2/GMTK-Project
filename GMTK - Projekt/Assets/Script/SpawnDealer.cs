using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDealer : MonoBehaviour
{
    private bool isSpawned = true;
    public DayNightCycle2D DayNightCycler;
    public GameObject dealer;

    private void Start()
    {
        isSpawned = true;
    }

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
