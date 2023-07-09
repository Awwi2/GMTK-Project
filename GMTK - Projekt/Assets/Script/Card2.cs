using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card2 : MonoBehaviour
{
    public Animator Card1;
    public Animator Card3;

    public ManageCards Manager;

    public void StartCard2()
    {
        Card3.Play("card_float_in");
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
        SceneManager.LoadScene("World Scene");
    }
}
