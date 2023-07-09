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
    private void loadWorld()
    {
        SceneManager.LoadScene("World Scene");

    }

    public void SFX()
    {

    }

    public void Music()
    {

    }
}
