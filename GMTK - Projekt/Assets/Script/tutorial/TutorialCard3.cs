using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialCard3 : MonoBehaviour
{
    public Button card1obj;
    public Button card2obj;

    private Animator Card1;
    private Animator Card2;

    private void Start()
    {
        Card1 = card1obj.gameObject.GetComponent<Animator>();
        Card2 = card2obj.gameObject.GetComponent<Animator>();
    }

    public void StartCard2()
    {
        return;
    }

    public void select()
    {
        card1obj.enabled = false;
        card2obj.enabled = false;
        StartCoroutine(SelectThis());
    }

    public IEnumerator SelectThis()
    {
        Card1.Play("card_not_selected");
        yield return new WaitForSeconds(0.25f);
        Card2.Play("card_not_selected");
        yield return new WaitForSeconds(0.75f);
        this.GetComponent<Animator>().Play("card_selected");

    }

    public void SwitchToDay()
    {
        SceneManager.LoadScene("Menu");
    }
}
