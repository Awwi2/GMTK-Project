using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageCards : MonoBehaviour
{
    public StatManager stats;

    public Text name1;
    public Text description1;
    public Text effect1_1;
    public Text effect2_1;
    public Text effect3_1;
    public Image image1_1;
    public Image image2_1;

    public Text name2;
    public Text description2;
    public Text effect1_2;
    public Text effect2_2;
    public Text effect3_2;
    public Image image1_2;
    public Image image2_2;

    public Text name3;
    public Text description3;
    public Text effect1_3;
    public Text effect2_3;
    public Text effect3_3;
    public Image image1_3;
    public Image image2_3;

    private Card card1;
    private Card card2;
    private Card card3;

    private Card[] cards;

    private void Awake()
    {
        cards = Resources.LoadAll<Card>("Cards");
        UpdateCards();
    }

    public void UpdateCards()
    {
        card1 = cards[Random.Range(0, cards.Length)];
        card2 = cards[Random.Range(0, cards.Length)];
        card3 = cards[Random.Range(0, cards.Length)];
        while (card1 == card2)
        {
            card2 = cards[Random.Range(0, cards.Length)];
        }
        while (card1 == card3 || card2 == card3)
        {
            card2 = cards[Random.Range(0, cards.Length)];
        }
        name1.text = card1.name;
        description1.text = card1.description;
        effect1_1.text = card1.effect1;
        effect2_1.text = card1.effect2;
        effect3_1.text = card1.effect3;
        image1_1.sprite = card1.image; 
        image2_1.sprite = card1.image;

        name2.text = card2.name;
        description2.text = card2.description;
        effect1_2.text = card2.effect1;
        effect2_2.text = card2.effect2;
        effect3_2.text = card2.effect3;
        image1_2.sprite = card2.image;
        image2_2.sprite = card2.image;

        name3.text = card3.name;
        description3.text = card3.description;
        effect1_3.text = card3.effect1;
        effect2_3.text = card3.effect2;
        effect3_3.text = card3.effect3;
        image1_3.sprite = card3.image;
        image2_3.sprite = card3.image;
    }

    public void CardOne()
    {
        Debug.Log("test");
        stats.money += card1.moneyModifier;
        stats.popularity += card1.popularityModifier;
        stats.rent += card1.rentModifier;
        stats.risk += card1.riskModifier;
        stats.moneyPerPerson += card1.moneyPerPersonModifier;
        stats.UpdateValues();
    }

    public void CardTwo()
    {
        stats.money += card2.moneyModifier;
        stats.popularity += card2.popularityModifier;
        stats.rent += card2.rentModifier;
        stats.risk += card2.riskModifier;
        stats.moneyPerPerson += card2.moneyPerPersonModifier;
        stats.UpdateValues();
    }

    public void CardThree()
    {
        stats.money += card3.moneyModifier;
        stats.popularity += card3.popularityModifier;
        stats.rent += card3.rentModifier;
        stats.risk += card3.riskModifier;
        stats.moneyPerPerson += card3.moneyPerPersonModifier;
        stats.UpdateValues();
    }
}
