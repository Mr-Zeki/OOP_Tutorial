using UnityEngine;

public class CylinderFactory : Factory
{
    [SerializeField] private Cylinder cylinderPrefab;
    public override IShapes CreateShapes(Vector3 position)
    {
        GameObject cylinderInstance = Instantiate(cylinderPrefab.gameObject, position, Quaternion.identity);
        Cylinder newCylinder = cylinderInstance.GetComponent<Cylinder>();

        newCylinder.Initialize();
        newCylinder.MakeSound();

        return newCylinder;
    }
}
