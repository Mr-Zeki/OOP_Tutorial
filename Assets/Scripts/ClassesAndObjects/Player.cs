using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Oyuncu özellikleri
    public string playerName = "Hero";
    public int health = 100;
    public int score = 0;

    // Oyuncu davranýþlarý
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(playerName + " has taken " + damage + " damage. Remaining health: " + health);
    }

    public void IncreaseScore(int points)
    {
        score += points;
        Debug.Log(playerName + " earned " + points + " points. Total score: " + score);
    }
}
