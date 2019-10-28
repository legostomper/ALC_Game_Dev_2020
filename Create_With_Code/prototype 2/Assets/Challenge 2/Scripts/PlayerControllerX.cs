using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float Dograte = 0.70f;
    private float NextDog = 0.70f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > NextDog)
        {
            NextDog = Time.time + Dograte ;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
