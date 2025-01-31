using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IShapes
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Initialize()
    {
        Debug.Log("Cube initialize");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }
    
    
    
}
