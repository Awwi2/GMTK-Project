using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;
    public string effect1;
    public string effect2;
    public string effect3;

    public Sprite image;

    public int moneyModifier;
    public int popularityModifier;
    public int rentModifier;
    public int riskModifier;
    public int moneyPerPersonModifier;

    public int rarity;


}
