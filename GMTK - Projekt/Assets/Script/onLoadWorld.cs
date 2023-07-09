using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLoadWorld : MonoBehaviour
{

    public GameObject neonsign;


    void Start()
    {
        StatManager.Instance.UpdateValues();
        if (StatManager.Instance.neonSign)
        {
            neonsign.SetActive(true);
        }
    }

}
