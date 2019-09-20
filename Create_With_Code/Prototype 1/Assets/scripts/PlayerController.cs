using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player control private variables
    private  float speed = 20f;
    private float turnSpeed = 15f;
    private float horizontalInput;
    private float forwardInput;

    // Start before the first frame update
    void Start()
    {
        
    }

    // Update once per frame
    void Update()
    {
        //to help turn the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    
        // We'll move the vehicle forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
