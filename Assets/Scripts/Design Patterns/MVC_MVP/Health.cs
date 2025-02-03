using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action OnHealthChanged;

    private const int minHealth = 0;
    private const int maxHealth = 100;
    private int currentHealth;
    
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int MinHealth = minHealth;
    public int MaxHealth = maxHealth;

    public void IncreaseHealth(int increaseAmount)
    {
        currentHealth += increaseAmount;
        currentHealth = Mathf.Max(currentHealth, minHealth);
        UpdateHealth();
    }

    public void DecreaseHealth(int decreaseAmount)
    {
        currentHealth -= decreaseAmount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        OnHealthChanged?.Invoke();
    }
}