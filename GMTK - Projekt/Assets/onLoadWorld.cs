using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLoadWorld : MonoBehaviour
{

    public GameObject[] NPCList;
    public GameObject neonsign;


    void Start()
    {
        if (StatManager.Instance.neonSign)
        {
            neonsign.SetActive(true);
        }
    }

}
