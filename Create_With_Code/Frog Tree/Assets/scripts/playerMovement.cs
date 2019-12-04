using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public float jumpForce = 7f;
    public float speed = 0.1f;
    public float rotationSpeed = 1f;
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
        if (Input.GetKey(KeyCode.W) && !gameOver)
        {
            transform.Translate(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.S) && isOnGround && !gameOver)
        {
            transform.Translate(Vector3.right * back);
        }

        if (Input.GetKey(KeyCode.D) && !gameOver)
        {
            transform.Rotate(Vector3.up * turnSpeed);
        }

        if (Input.GetKey(KeyCode.A) && !gameOver)
        {
            transform.Rotate(Vector3.down * turnSpeed);
        }

        if (Input.GetKey(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }

        private void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
            }
            else if (collision.gameObject.CompareTag("BadBoi"))
            {
                gameOver = true;
                Debug.Log("Game Over");
            
            }

        }
    
}

