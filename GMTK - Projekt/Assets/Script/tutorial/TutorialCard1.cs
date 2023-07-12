using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialCard1 : MonoBehaviour
{
    public Button card2obj;
    public Button card3obj;

    private Animator Card2;
    private Animator Card3;

    private void Start()
    {
        Card2 = card2obj.gameObject.GetComponent<Animator>();
        Card3 = card3obj.gameObject.GetComponent<Animator>();
    }

    public void StartThis()
    {
        this.GetComponent<Animator>().Play("card_float_in");
    }

    public void select()
    {
        card2obj.enabled = false;
        card3obj.enabled = false;
        StartCoroutine(SelectThis());
    }

    public void StartCard2()
    {
        Card2.Play("card_float_in");
    }

    public IEnumerator SelectThis()
    {
        Card2.Play("card_not_selected");
        yield return new WaitForSeconds(0.25f);
        Card3.Play("card_not_selected");
        yield return new WaitForSeconds(0.75f);
        this.GetComponent<Animator>().Play("card_selected");

    }

    public void SwitchToDay()
    {
        SceneManager.LoadScene("Menu");
    }
}
