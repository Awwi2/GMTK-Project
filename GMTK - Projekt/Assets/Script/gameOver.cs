using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public GameObject GameOverScreen;

    void Update()
    {
        if (StatManager.Instance.money <= 0)
        {
            Time.timeScale = 0f;
            GameOverScreen.SetActive(true);
        }
    }
}
