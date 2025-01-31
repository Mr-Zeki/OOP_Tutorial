using UnityEngine;

public class CapsuleFactory : Factory
{
    [SerializeField] private Capsule capsulePrefab;
    public override IShapes CreateShapes(Vector3 position)
    {
        GameObject capsuleInstance = Instantiate(capsulePrefab.gameObject, position, Quaternion.identity);
        Capsule newCapsule = capsuleInstance.GetComponent<Capsule>();

        newCapsule.Initialize();
        newCapsule.MakeSound();

        return newCapsule;
    }
}
