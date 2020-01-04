using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoiSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 25;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);



        Vector3 GenerateSpawnPosition()
        {
            float spawnPosX = Random.Range(-spawnRange, spawnRange);
            float spawnPosZ = Random.Range(55, -10);
            Vector3 randomPos = new Vector3(spawnPosX, 100, spawnPosZ);
            return randomPos;
        }

    }


}

   


    
    






