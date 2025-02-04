using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "CardSO")]
public class CardSO : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int cardCost;
    public int cardDefense;
    public int cardAttack;
    public Sprite cardSprite;
}