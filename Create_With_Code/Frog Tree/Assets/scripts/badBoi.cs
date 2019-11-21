using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badBoi : MonoBehaviour
{

    private Rigidbody playerRb;
    public float floatForce = 3;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.CompareTag("Ground"))
        {
            playerRb.AddForce(Vector3.up * floatForce * 20);

        }

    }
}