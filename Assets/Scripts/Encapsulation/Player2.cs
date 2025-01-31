using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Private deðiþkenler
    private int health = 100;
    private int maxHealth = 100;

    // Saðlýk deðerine sadece okunabilir þekilde eriþim
    public int Health
    {
        get { return health; }
    }

    // Saðlýk arttýrma veya azaltma iþlemleri için metotlar
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
        Debug.Log("Player took damage. Current health: " + health);
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        Debug.Log("Player healed. Current health: " + health);
    }
}
