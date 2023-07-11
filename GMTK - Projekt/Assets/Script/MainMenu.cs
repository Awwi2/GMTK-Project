using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play()
    {

        Invoke("loadWorld", 0.2f);
    }
    public void Tutorial()
    {

        Invoke("loadTutorial", 0.2f);
    }
    private void loadWorld()
    {
        SceneManager.LoadScene("World Scene");

    }
    private void loadTutorial()
    {
        SceneManager.LoadScene("Tutorial World Scene");

    }

    public void Quitgame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
