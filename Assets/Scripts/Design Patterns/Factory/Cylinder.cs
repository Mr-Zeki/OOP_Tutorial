using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour, IShapes
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Initialize()
    {
        Debug.Log("Cylinder initialize");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }


}
