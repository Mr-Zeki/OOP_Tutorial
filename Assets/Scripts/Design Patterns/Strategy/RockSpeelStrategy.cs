using UnityEngine;

[CreateAssetMenu(fileName = "Rock Speel", menuName = "Speels/Rock Speel")]
public class RockSpeelStrategy : AbilityStrategy
{
    [SerializeField] private GameObject rockParticlePrefab;
    [SerializeField] private float selfDestructionDuration;

    public override void UseAbility(Transform desiredPosition, Quaternion desiredRotation)
    {
        Debug.Log("Rock Speel Activated!");
        GameObject rockInstance = Instantiate(rockParticlePrefab, desiredPosition.position.With(y : 1.25f), desiredRotation);
        Destroy(rockInstance, selfDestructionDuration);
    }
}