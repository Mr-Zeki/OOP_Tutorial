using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Private de�i�kenler
    private int health = 100;
    private int maxHealth = 100;

    // Sa�l�k de�erine sadece okunabilir �ekilde eri�im
    public int Health
    {
        get { return health; }
    }

    // Sa�l�k artt�rma veya azaltma i�lemleri i�in metotlar
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
