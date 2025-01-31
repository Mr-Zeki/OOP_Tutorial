
using UnityEngine;

[CreateAssetMenu(fileName = "BallStateSO", menuName = "BallStateSO")]
public class BallStateSO : ScriptableObject
{
    [field: SerializeField] public float ForceMagnitude { get; private set; }

    [field: SerializeField] public int MaxHealth { get; private set; }

    [field: SerializeField] public float BounceAmount { get; private set; }

    [field: SerializeField] public float MaxFriction { get; private set; }
}
