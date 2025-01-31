
using UnityEngine;

public abstract class Factory : MonoBehaviour
{
  public abstract IShapes CreateShapes(Vector3 position);
}
