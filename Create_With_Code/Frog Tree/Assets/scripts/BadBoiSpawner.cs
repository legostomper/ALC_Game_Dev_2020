using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoiSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;

    private float spawnDelay = 1f;
    private float spawnInterval = 0.01f;

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        
    }

    // Spawn obstacles
    void SpawnObjects()
    {
        Instantiate;

    }

}


