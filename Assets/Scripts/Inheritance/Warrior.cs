using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : BasePlayer
{
    public int rage;

    public override void SpecialAbility()
    {
        rage += 10;
        Debug.Log(playerName + " used Berserk! Rage increased to " + rage);
    }
}
