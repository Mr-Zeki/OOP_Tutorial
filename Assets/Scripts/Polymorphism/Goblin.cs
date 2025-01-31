using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    public override void Attack()
    {
        Debug.Log(enemyName + " throws a rock!");
    }
}
