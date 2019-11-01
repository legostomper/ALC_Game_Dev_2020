using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public float HorizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        HorizontalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        if (Input.GetKey(KeyCode.W))
           {
            transform.Translate(Vector3.forward * speed);
        }
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * Time.deltaTime * HorizontalInput * rotationSpeed);
    }
}

