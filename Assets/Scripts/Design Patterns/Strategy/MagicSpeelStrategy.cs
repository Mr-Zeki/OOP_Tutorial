using UnityEngine;

[CreateAssetMenu(fileName = "Magic Speel", menuName = "Speels/Magic Speel")]
public class MagicSpeelStrategy : AbilityStrategy
{
    [SerializeField] private GameObject magicParticlePrefab;
    [SerializeField] private float selfDestructionDuration;

    public override void UseAbility(Transform desiredPosition, Quaternion desiredRotation)
    {
        Debug.Log("Magic Speel Activated!");
        GameObject magicInstance = Instantiate(magicParticlePrefab, desiredPosition.position.With(y : 1.25f), desiredRotation);
        Destroy(magicInstance, selfDestructionDuration);
    }
}