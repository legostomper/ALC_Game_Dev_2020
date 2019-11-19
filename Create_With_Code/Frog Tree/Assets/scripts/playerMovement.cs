using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public float jumpForce = 10;
    public float speed = 0.1f;
    public float rotationSpeed = 5f;
    public float HorizontalInput;
    public float turnSpeed = 10f;
    public float back = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {


        // move the frog forward and back
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * back);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * turnSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * turnSpeed);
        }

        if (Input.GetKey(KeyCode.Space) && isOnGround && !gameOver)
        {

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }


        void OnCollisionEnter(Collision other)
        {

            if (other.gameObject.CompareTag("BadBoi"))
            {

                Debug.Log("Game Over!");

                Destroy(other.gameObject);

            }


        }
    }
}

