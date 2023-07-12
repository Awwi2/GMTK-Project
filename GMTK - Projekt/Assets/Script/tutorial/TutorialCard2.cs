using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialCard2 : MonoBehaviour
{
    public Button card1obj;
    public Button card3obj;

    private Animator Card1;
    private Animator Card3;

    private void Start()
    {
        Card1 = card1obj.gameObject.GetComponent<Animator>();
        Card3 = card3obj.gameObject.GetComponent<Animator>();
    }

    public void StartCard2()
    {
        Card3.Play("card_float_in");
    }

    public void select()
    {
        card1obj.enabled = false;
        card3obj.enabled = false;
        StartCoroutine(SelectThis());
    }

    public IEnumerator SelectThis()
    {
        Card1.Play("card_not_selected");
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
