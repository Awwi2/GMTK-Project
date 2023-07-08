using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class DayNightCycle2D : MonoBehaviour
{
    public GameObject LayertoIgnore;
    public List<GameObject> Planets = new List<GameObject>();

    public float speed;
    public bool isDay = true;

    public float GlobalLightNight = 0.125f;
    public float GlobalLightDay = 0.4f;
    private Light2D GlobalLight;
    public float GlobalLightSpeed = 0.15f;


    private float Distance;
    private Vector3 targetPosition;
    private Vector3 startPosition;
    private float DaychangePos;

    void Start()
    {
        GlobalLightSpeed = GlobalLightSpeed * speed;
        GlobalLight = transform.GetChild(0).gameObject.GetComponent<Light2D>();

        DaychangePos = Planets[1].transform.position.x / 2;
        int AmountPlanets = Planets.Count;
        Distance = 0 - ( Planets[AmountPlanets-1].transform.position.x / 2 );
        //Set Positions
        targetPosition = new Vector3(Distance, Planets[0].transform.position.y, Planets[0].transform.position.z);

        startPosition = new Vector3( ( 0 - Distance ) + Planets[1].transform.position.x, Planets[0].transform.position.y, Planets[0].transform.position.z);

        foreach (GameObject obj in Planets)
        {
            Physics2D.IgnoreCollision(LayertoIgnore.GetComponent<Collider2D>(), obj.GetComponent<Collider2D>());
        }
    }


    void Update()
    {

        foreach (GameObject obj in Planets)
        {

            //Move obj
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, targetPosition, speed*Time.deltaTime);
            
            // Reset Pos
            if (obj.transform.position == targetPosition)
            {
                obj.transform.position = startPosition;
            }

        }
        Debug.Log("isDay: " + isDay);

        //Day & Night GlobalLight

        if (isDay == true)
        {

            GlobalLight.intensity = Mathf.MoveTowards( GlobalLight.intensity, GlobalLightDay, GlobalLightSpeed * Time.deltaTime);
        }
        else
        {
            GlobalLight.intensity = Mathf.MoveTowards(GlobalLight.intensity, GlobalLightNight, GlobalLightSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SunLight"))
        {
            isDay = !isDay;
            Debug.Log("isDay: " + isDay);

        }
    }

    public void placeLights(int PlaceLights)
    {
        if (PlaceLights > 0)
        {
            //Place Lights
            if (PlaceLights % 2 == 0)
            {
                Instantiate(gameObject.GetComponent<DayNightCycle2DModifier>().Sun, new Vector3((PlaceLights - 1) * gameObject.GetComponent<DayNightCycle2DModifier>().Spacing, GetComponent<Transform>().transform.position.y, GetComponent<Transform>().transform.position.z), Quaternion.identity, transform);
                //Debug.Log("PlaceLights: " + PlaceLights + " is even");

            }
            else if (PlaceLights % 2 == 1)
            {
                Instantiate(gameObject.GetComponent<DayNightCycle2DModifier>().Moon, new Vector3((PlaceLights - 1) * gameObject.GetComponent<DayNightCycle2DModifier>().Spacing, GetComponent<Transform>().transform.position.y, GetComponent<Transform>().transform.position.z), Quaternion.identity, transform);
                //Debug.Log("PlaceLights: " + PlaceLights + " is odd");
            }

            // Loop placeLights
            PlaceLights -= 1;
            placeLights(PlaceLights);

        }
        else if (PlaceLights == 0 && gameObject.GetComponent<DayNightCycle2DModifier>().LightstoPlace != 0)
        {
            gameObject.GetComponent<DayNightCycle2DModifier>().AmountLights = gameObject.GetComponent<DayNightCycle2DModifier>().LightstoPlace;
            gameObject.GetComponent<DayNightCycle2DModifier>().savecheckAmount = gameObject.GetComponent<DayNightCycle2DModifier>().AmountLights;
            gameObject.GetComponent<DayNightCycle2DModifier>().LightstoPlace = 0;
            gameObject.GetComponent<DayNightCycle2DModifier>().saveSpacing = gameObject.GetComponent<DayNightCycle2DModifier>().Spacing;

        }
    }
}
