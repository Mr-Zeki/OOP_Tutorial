using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // Player nesnesini oluþtur
        Player player = new Player();
        player.playerName = "Warrior";

        // Oyuncuya hasar ver ve puan ekle
        player.TakeDamage(20);
        player.IncreaseScore(50);
    }
}
