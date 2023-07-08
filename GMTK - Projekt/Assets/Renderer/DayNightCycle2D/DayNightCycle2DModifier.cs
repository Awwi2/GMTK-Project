using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DayNightCycle2DModifier : MonoBehaviour
{
    //Amount of Lights
    [Min(2)]
    public int AmountLights;
    public int savecheckAmount;
    public int LightstoPlace;

    //Placing Lights
    [Min(2)]
    public float Spacing;
    public float saveSpacing;

    public GameObject Moon;
    public GameObject Sun;

    void Update()
    {

        gameObject.GetComponent<DayNightCycle2D>().placeLights(LightstoPlace);

        if (savecheckAmount != AmountLights || saveSpacing != Spacing)
        {
            LightstoPlace = AmountLights;

            gameObject.GetComponent<BoxCollider2D>().size = new Vector3(Spacing, 1);

            //Delete Lights
            int nbChildren = gameObject.transform.childCount;

            for (int i = nbChildren - 1; i >= 0; i--)
            {
                if (gameObject.transform.GetChild(i).name != "Global Light 2D")
                {
                    DestroyImmediate(gameObject.transform.GetChild(i).gameObject);
                }
            }
        }

    }


}
