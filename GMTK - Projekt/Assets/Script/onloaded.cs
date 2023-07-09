using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onloaded : MonoBehaviour
{
    void Start()
    {
        StatManager.Instance.UpdateValues();
    }
}
