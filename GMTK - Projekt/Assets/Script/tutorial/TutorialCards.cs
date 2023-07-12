using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialCards : MonoBehaviour
{
    public Text money;
    public Text moneyPerPerson;
    public Text popularity;
    public Text days;
    public Text tutorial;

    public Button card1;
    public Button card2;
    public Button card3;

    public Button advancer;

    public int current = 0;

    void Awake()
    {
        Time.timeScale = 1;
        card1.enabled = false;
        card2.enabled = false;
        card3.enabled = false;
    }

    void Update()
    {
        if (current == 1)
        {
            tutorial.text = "It looks like you lost some money, this is you rent";
            current++;
        }
        else if (current == 3)
        {
            tutorial.text = "it starts off at 200 and will later be indicated here";
            current++;
        }
        else if (current == 5)
        {
            tutorial.text = "Three cards will appear here";
            current++;
        }
        else if (current == 7)
        {
            card1.GetComponent<TutorialCard1>().StartThis();
            current++;
        }
        else if (current == 9)
        {
            tutorial.text = "You have to choose one";
            current++;
        }
        else if (current == 11)
        {
            tutorial.text = "They each have upsides and downsides";
            current++;
        }
        else if (current == 13)
        {
            tutorial.text = "Some may cost money or increase rent (See middle)";
            current++;
        }
        else if (current == 15)
        {
            tutorial.text = "Some may lower stats and some may increase Risk";
            current++;
        }
        else if (current == 17)
        {
            tutorial.text = "With high risk you may get sued";
            current++;
        }
        else if (current == 19)
        {
            tutorial.text = "Getting sued will decrease your money and Popularity";
            current++;
        }
        else if (current == 21)
        {
            tutorial.text = "Some cards may lower or even reset your risk";
            current++;
        }
        else if (current == 23)
        {
            tutorial.text = "For now this is it for the Tutorial";
            current++;
        }
        else if (current == 25)
        {
            tutorial.text = "Choose a card to get back to the menu";
            current++;
            card1.enabled = true;
            card2.enabled = true;
            card3.enabled = true;
        }
    }

    public void advance()
    {
        current++;
    }
}
