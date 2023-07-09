using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNPC : MonoBehaviour
{
    public float Spawnrate;
    public GameObject[] NPCList;


    void Start()
    {
        StatManager.Instance.UpdateValues();
        if (StatManager.Instance.popularity != 0)
        {
            SpawnNPC();
        }


    }
    void reRun()
    {
        Spawnrate = StatManager.Instance.popularity/5;
        Invoke("SpawnNPC", (20f / Spawnrate) - Random.Range(0f,1.5f));

    }

    public void SpawnNPC()
    {
        Instantiate(NPCList[Random.Range(0, 3)], transform.position, Quaternion.identity) ;
        reRun();
    }
}
