using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoiSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 10, 0);
    private float startDelay = 3f;
    private float repeatRate = 0.0001f;
    private playerMovement playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        GameObject.Find("Player").GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        
    }



}
