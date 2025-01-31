using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        // Sava��� olu�tur
        Warrior warrior = gameObject.AddComponent<Warrior>();
        warrior.playerName = "Warrior";
        warrior.health = 150;
        warrior.rage = 0;

        // B�y�c� olu�tur
        Mage mage = gameObject.AddComponent<Mage>();
        mage.playerName = "Mage";
        mage.health = 100;
        mage.mana = 50;

        // Oyuncular� test et
        warrior.TakeDamage(30);
        warrior.SpecialAbility();

        mage.TakeDamage(20);
        mage.SpecialAbility();
    }
}
