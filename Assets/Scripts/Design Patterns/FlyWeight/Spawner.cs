
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public float spawnInterval = 2f; 
    [SerializeField] private Transform spawnArea; 
    [SerializeField] private TextMeshProUGUI spawnCountText;
    private int spawnCount;


    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            if (spawnCount <1000)
                SpawnObject();
                yield return new WaitForSeconds(spawnInterval);
        }
    }
    void UpdateSpawnCountText()
    {
        if (spawnCountText != null)
        {
            spawnCountText.text = "Spawn Sayısı: " + spawnCount;
        }
    }

    void SpawnObject()
    {
         
        Instantiate(objectToSpawn, spawnArea.transform.position, Quaternion.identity);
        spawnCount++;
        UpdateSpawnCountText();
    }
}
