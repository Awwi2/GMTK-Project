using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public PauseMenu PauseMenu;

    public Text money;
    public Text moneyPerPerson;
    public Text popularity;
    public Text days;
    public Text tutorial;

    public Button advancer;

    public int current = 0;

    void Start()
    {
        Time.timeScale = 0;
        PauseMenu.GetAudioMixerVolume();
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Menu");
        }

        if (current == 1)
        {
            tutorial.text = "We are so glad you could make it";
            current++;
        }
        else if (current == 3)
        {
            tutorial.text = "You are the Boss for the next [Insert time durration]";
            current++;
        }
        else if (current == 5)
        {
            tutorial.text = "You can always skip this Tutorial by pressing ESC";
            current++;
        }
        else if (current == 7)
        {
            tutorial.text = "What you cant Skip is your employment here";
            current++;
        }
        else if (current == 9)
        {
            tutorial.text = "Now lets show you the ropes";
            current++;
        }
        else if (current == 11)
        {
            tutorial.text = "Every Day People will come to your Casino";
            current++;
        }
        else if (current == 13)
        {
            tutorial.text = "Look There comes one right now";
            current++;
        }
        else if (current == 15)
        {
            Time.timeScale = 1;
            advancer.gameObject.SetActive(false);
            current++;
        }
        else if (current == 17)
        {
            Time.timeScale = 0;
            advancer.gameObject.SetActive(true);
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(-186, -150, 0);
            money.gameObject.SetActive(true);
            tutorial.text = "Look, he got you some money";
            current++;
        }
        else if (current == 19)
        {
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -150, 0);
            tutorial.text = "How much a person gives you is decided by this Value";
            moneyPerPerson.gameObject.SetActive(true);
            current++;
        }
        else if (current == 21)
        {
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(-221, 15, 0);
            tutorial.text = "Here comes another one";
            moneyPerPerson.gameObject.SetActive(true);
            current++;
        }
        else if (current == 23)
        {
            Time.timeScale = 1;
            advancer.gameObject.SetActive(false);
            current++;
        }
        else if (current == 25)
        {
            Time.timeScale = 0;
            money.text = "1100";
            advancer.gameObject.SetActive(true);
            tutorial.text = "Here you can see how popular you casino is";
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(74, -143, 0);
            popularity.gameObject.SetActive(true);
            current++;
        }
        else if (current == 27)
        {
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(142, -143, 0);
            tutorial.text = "This Decides How many people come";
            moneyPerPerson.gameObject.SetActive(true);
            current++;
        }
        else if (current == 29)
        {
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(150, 27, 0);
            tutorial.text = "Oh Look another Person is coming";
            current++;
        }
        else if (current == 31)
        {
            Time.timeScale = 1;
            advancer.gameObject.SetActive(false);
            current++;
        }
        else if (current == 33)
        {
            Time.timeScale = 0;
            advancer.gameObject.SetActive(true);
            tutorial.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 196, 0);
            tutorial.text = "it's is our Representative, the shady homeless person";
            current++;
        }
        else if (current == 35)
        {
            tutorial.text = "He will end your day and give you a decision";
            current++;
        }
        else if (current == 37)
        {
            tutorial.text = "What day it is you can see up here";
            days.gameObject.SetActive(true);
            current++;
        }
        else if (current == 39)
        {
            tutorial.text = "Lets go make that Decision right now";
            current++;
        }
        else if (current == 41)
        {
            SceneManager.LoadScene("Tutorial Poker Table");
        }


    }

    public void advance()
    {
        current++;
    }
}