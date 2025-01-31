using System;
using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    private int coinCount;

    private void OnEnable()
    {
        PlayerInteractions.OnCoinCollected += PlayerInteractions_OnCoinCollected;
    }

    private void PlayerInteractions_OnCoinCollected()
    {
        coinCount++;
        coinText.text = "Coin: " + coinCount.ToString();
    }

    private void OnDisable()
    {
        PlayerInteractions.OnCoinCollected -= PlayerInteractions_OnCoinCollected;
    }
}