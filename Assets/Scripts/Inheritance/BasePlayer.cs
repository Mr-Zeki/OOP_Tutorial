using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public string playerName;
    public int health;
    public int mana;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(playerName + " took " + damage + " damage. Remaining health: " + health);
    }

    public virtual void SpecialAbility()
    {
        Debug.Log(playerName + " uses a special ability!");
    }
}
