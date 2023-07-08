using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateLight2D : MonoBehaviour
{
    void Awake()
    {

        transform.parent.gameObject.GetComponent<DayNightCycle2D>().Planets.Add(gameObject);

    }

}
