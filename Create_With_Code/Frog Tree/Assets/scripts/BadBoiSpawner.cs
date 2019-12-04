using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoiSpawner : MonoBehaviour
{
    public class Offsets : MonoBehaviour
    {

        public GameObject[] prefabs;
        public GameObject player;

        float xPos;
        float yPos;
        float zPos;

        const float radius = 0.5f;

        public void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        public void SpawnObject()
        {
            xPos = Random.Range(-3, 3); //Makes a random number from -3 to 3.

            if (xPos < -1)
                xPos = -2;
            else if (xPos > 1)
                xPos = 2;
            else
                xPos = 0;
            //This will align your xPos to 2, 0 or -2.

            zPos = player.transform.position.z + 50;
            //I'm not sure if this is what you want.
            //If not you can simply use the Random class methods

            yPos = CheckForYPosition();
        }

        public float CheckForYPosition()
        { //This is a "kind-of" loop that checks if the place is free. if not add 2 to yPos and recheck.
            if (Physics.CheckSphere(new Vector3(xPos, yPos, zPos), radius))
            {
                yPos += 15;
                return CheckForYPosition();
            }
            else
            {
                return yPos;
            }
        }

    }
}