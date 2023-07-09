using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNPC : MonoBehaviour
{
    public float Spawnrate;
    public GameObject[] NPCList;


    void Start()
    {
        SpawnNPC();
    }
    void reRun()
    {
        Spawnrate = StatManager.Instance.popularity/5;
        Invoke("SpawnNPC", 10 / Spawnrate);

    }

    public void SpawnNPC()
    {
        Instantiate(NPCList[Random.Range(0, 3)], transform.position, Quaternion.identity) ;
        reRun();
    }
}
