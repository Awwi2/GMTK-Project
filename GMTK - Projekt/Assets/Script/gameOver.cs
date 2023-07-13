using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject GameOverScreen;
    bool tryload;

    private void Awake()
    {
        tryload = false;
    }
    void Update()
    {
        if (StatManager.Instance.money < 0 && tryload != true)
        {
            GameOverScreen.SetActive(true);
            ScoreManager.Instance.UpdateScore();
            Time.timeScale = 0f;
        }
    }
    public void TryAgain()
    {
        tryload = true;
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
        tryload = true;
        Time.timeScale = 1f;
        StatManager.Instance.ResetValues();
        Invoke("loadMenu", 0.2f);
    }
    private void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
