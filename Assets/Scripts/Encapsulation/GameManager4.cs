using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager4 : MonoBehaviour
{
    void Start()
    {
        // Oyuncu nesnesini olu�tur
        Player2 player = gameObject.AddComponent<Player2>();

        // Sa�l�k y�netimi
        player.TakeDamage(30);  // Hasar al�r
        Debug.Log("Player health after damage: " + player.Health);

        player.Heal(20);        // Sa�l�k kazan�r
        Debug.Log("Player health after healing: " + player.Health);

        player.TakeDamage(100); // Sa�l�k s�f�rlan�r
        Debug.Log("Player health after massive damage: " + player.Health);
    }
}
