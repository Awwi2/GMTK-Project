using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject square;
    public int xSize = 5;
    public int ySize = 5;
    private RectTransform rects;


    // Start is called before the first frame update
    void Start()
    {
        rects = square.GetComponent<RectTransform>();

        for (float x = -1 * (xSize - 1) * rects.rect.width / 2; x < xSize * rects.rect.width / 2; x += rects.rect.width)
        {
            for (float y = -1 * (ySize - 1) * rects.rect.height / 2; y < ySize * rects.rect.height / 2; y += rects.rect.height)
            {
                GameObject newIns = Instantiate(square);
                newIns.transform.SetParent(transform.parent);
                newIns.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
