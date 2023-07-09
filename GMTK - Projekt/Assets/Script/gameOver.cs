using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void TryAgain()
    {
        Time.timeScale = 1f;
        StatManager.Instance.ResetValues();
        Invoke("loadWorld",0.2f);
    }
    private void loadWorld()
    {
        GameOverScreen.SetActive(false);
        SceneManager.LoadScene("World Scene");
    }
    public void StartMenu()
    {
        Time.timeScale = 1f;
        StatManager.Instance.ResetValues();
        Invoke("loadMenu", 0.2f);
    }
    private void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
