using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badBoi : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    public bool isOnGround = true;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update() 
    {
        Vector3 lookDirection = (Player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

      
    }


}