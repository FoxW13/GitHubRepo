using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weyouth
		 * Prototype 2
		 * Assignment 3
		 * This code destroys the food prefab when it comes in contact with another collider.
		 */

public class DetectCollisions : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
