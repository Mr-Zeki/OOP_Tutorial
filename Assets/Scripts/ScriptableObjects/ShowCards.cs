using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowCards : MonoBehaviour
{
    public CardSO cardSO;
    
    [SerializeField] private TMP_Text cardName;
    [SerializeField] private TMP_Text cardDescription;
    [SerializeField] private TMP_Text cardCost;
    [SerializeField] private TMP_Text cardDefense;
    [SerializeField] private TMP_Text cardAttack;
    [SerializeField] private Image cardSprite;

    private void Start()
    {
        cardName.text = cardSO.cardName;
        cardDescription.text = cardSO.cardDescription;
        cardCost.text = cardSO.cardCost.ToString();
        cardDefense.text = cardSO.cardDefense.ToString();
        cardAttack.text = cardSO.cardAttack.ToString();
        cardSprite.sprite = cardSO.cardSprite;
    }
}