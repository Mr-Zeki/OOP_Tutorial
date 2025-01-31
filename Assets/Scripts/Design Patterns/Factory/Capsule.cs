using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Capsule : MonoBehaviour, IShapes
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // ReSharper disable Unity.PerformanceAnalysis
    public void Initialize()
    {
        Debug.Log("Capsule initialize");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }

    
}
