using UnityEngine;

public abstract class AbilityStrategy : ScriptableObject
{
  public abstract void UseAbility(Transform desiredPosition, Quaternion desiredRotation);
}