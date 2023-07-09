using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDealer : MonoBehaviour
{
    public bool isSpawned = true;
    public DayNightCycle2D DayNightCycler;
    public GameObject dealer;

    private void Awake()
    {
        Invoke("spawn", 7.5f);
    }

    void spawn()
    {

            Instantiate(dealer);
    }
}
