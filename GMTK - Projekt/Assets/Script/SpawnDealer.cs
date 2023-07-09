using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDealer : MonoBehaviour
{
    private bool isSpawned = true;
    public DayNightCycle2D DayNightCycler;
    public GameObject dealer;

    private void Awake()
    {
        isSpawned = true;
    }

    void Update()
    {
        if (!DayNightCycler.isDay && isSpawned == false)
        {
            isSpawned = true;
            Instantiate(dealer);
        } else if (DayNightCycler.isDay)
        {
            isSpawned = false;
        }
    }
}
