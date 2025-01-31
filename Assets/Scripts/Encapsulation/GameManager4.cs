using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager4 : MonoBehaviour
{
    void Start()
    {
        // Oyuncu nesnesini oluþtur
        Player2 player = gameObject.AddComponent<Player2>();

        // Saðlýk yönetimi
        player.TakeDamage(30);  // Hasar alýr
        Debug.Log("Player health after damage: " + player.Health);

        player.Heal(20);        // Saðlýk kazanýr
        Debug.Log("Player health after healing: " + player.Health);

        player.TakeDamage(100); // Saðlýk sýfýrlanýr
        Debug.Log("Player health after massive damage: " + player.Health);
    }
}
