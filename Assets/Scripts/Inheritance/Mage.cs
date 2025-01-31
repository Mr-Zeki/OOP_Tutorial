using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : BasePlayer
{
    public override void SpecialAbility()
    {
        if (mana >= 20)
        {
            mana -= 20;
            Debug.Log(playerName + " casts Fireball! Mana remaining: " + mana);
        }
        else
        {
            Debug.Log(playerName + " doesn't have enough mana!");
        }
    }
}
