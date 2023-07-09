using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card3 : MonoBehaviour
{
    public Animator Card1;
    public Animator Card2;

    public ManageCards Manager;

    public void StartCard2()
    {
        return;
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
        SceneManager.LoadScene("World Scene");
    }
}
