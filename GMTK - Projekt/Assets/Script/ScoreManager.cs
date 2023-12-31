using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int Score;

    Text[] Texts;
    private Text scoreText;
    private Text highscoreText;
    private Text highscoreTitel;

    public void FindUI()
    {
        Texts = GameObject.FindObjectsOfType<Text>();
        foreach (Text t in Texts)
        {
            if (t.name == "Score-Text")
            {
                scoreText = t;
            }
            else if (t.name == "Highscore-Text")
            {
                highscoreText = t;
            }
            else if (t.name == "Highscore-Title-obj")
            {
                highscoreTitel = t;
            }
        }
    }
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);


    }
    public void UpdateScore()
    {
        Score = StatManager.Instance.day;
        FindUI();

        if (Score >= PlayerPrefs.GetInt("Highscore"))
        {
            highscoreTitel.gameObject.GetComponent<Animator>().Play("highscore_new");
            PlayerPrefs.SetInt("Highscore", Score);
        }

        scoreText.text = "Your Casino was running for " + Score.ToString() + " Days";
        highscoreText.text = "Your Highscore is " + PlayerPrefs.GetInt("Highscore", Score).ToString() + " Days";
    }
}
