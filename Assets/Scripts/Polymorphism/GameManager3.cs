using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    void Start()
    {
        // Farklý düþman türleri oluþtur
        Enemy goblin = gameObject.AddComponent<Goblin>();
        goblin.enemyName = "Goblin";
        goblin.health = 50;

        Enemy dragon = gameObject.AddComponent<Dragon>();
        dragon.enemyName = "Dragon";
        dragon.health = 200;

        // Polymorphism örneði: Ayný metod farklý davranýr
        goblin.Attack(); // Goblin throws a rock!
        dragon.Attack(); // Dragon breathes fire!
    }
}
