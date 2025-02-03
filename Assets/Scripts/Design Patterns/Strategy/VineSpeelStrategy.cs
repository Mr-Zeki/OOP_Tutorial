using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "Vine Speel", menuName = "Speels/Vine Speel")]
public class VineSpeelStrategy : AbilityStrategy
{
    [SerializeField] private GameObject vineParticlePrefab;
    [SerializeField] private float selfDestructionDuration;

    public override void UseAbility(Transform desiredPosition, Quaternion desiredRotation)
    {
        Debug.Log("Vine Speel Activated!");
        GameObject vineInstance = Instantiate(vineParticlePrefab, desiredPosition.position.With(y : 1.25f), desiredRotation);
        Destroy(vineInstance, selfDestructionDuration);
    }
}