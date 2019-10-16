﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour



{
private float spawnRangeX = 20;
private float spawnPosZ = 20;
public GameObject[] animalPrefabs;
private float startDelay = 0f;
    private float spawnInterval = 1f;


    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  
    }




    // Update is called once per frame
    void Update()
    {

    }
        void SpawnRandomAnimal()
        {

            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                            0, spawnPosZ);

            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex], spawnPos,
                animalPrefabs[animalIndex].transform.rotation);

        }


    
}
