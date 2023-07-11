using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNPC : MonoBehaviour
{
    public float Spawnrate;
    public GameObject[] NPCList;


    void Start()
    {
        if (StatManager.Instance.popularity != 0)
        {
            SpawnNPC();
        }
    }

    void reRun()
    {
        Spawnrate = StatManager.Instance.popularity/5;
        Invoke("SpawnNPC", (12f / Spawnrate) - Random.Range(-0.5f,1.5f));

    }

    public void SpawnNPC()
    {
        Instantiate(NPCList[Random.Range(0, 3)], transform.position, Quaternion.identity) ;
        reRun();
    }
}
