
using UnityEngine;

public class CubeFactory : Factory
{
    [SerializeField] private Cube cubePrefab;
    public override IShapes CreateShapes(Vector3 position)
    {
        GameObject cubeInstance = Instantiate(cubePrefab.gameObject, position, Quaternion.identity);
        Cube newCube = cubeInstance.GetComponent<Cube>();

        newCube.Initialize();
        newCube.MakeSound();

        return newCube;
    }
}
