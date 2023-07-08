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
        float spawnIn = Random.Range(20f / Spawnrate, 20f);
        Debug.Log(spawnIn);
        Invoke("SpawnNPC", spawnIn);

    }

    public void SpawnNPC()
    {
        Instantiate(NPCList[Random.Range(0, 3)], transform.position, Quaternion.identity) ;
        reRun();
    }
}
