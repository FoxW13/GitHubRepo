using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 2
		 * Assignment 3
		 * This code destroys the animals and food objects when they go out of bounds that we set.
		 */

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 20;
    public float bottomBounds = -10;

    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < bottomBounds)
        {
            Debug.Log("Game Over!");

            Destroy(gameObject);
        }
    }
}
