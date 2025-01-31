using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    public override void Attack()
    {
        Debug.Log(enemyName + " breathes fire!");
    }
}
