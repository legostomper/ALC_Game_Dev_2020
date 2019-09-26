using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropSpin : MonoBehaviour

{
    public float speed = 5000000f;


    // Update is called once per frame
    void FixedUpdate()
    {

        // tilt the plane propeller
        transform.Rotate(Vector3.forward * speed * Time.deltaTime );
    }
}
