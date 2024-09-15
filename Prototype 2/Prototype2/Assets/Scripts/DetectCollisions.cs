using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weyouth
		 * Prototype 2
		 * Assignment 3
		 * This code destroys the food prefab when it comes in contact with another collider and incriments score.
		 */

public class DetectCollisions : MonoBehaviour
{
	private DisplayScore displayScoreScript;

	private void Start()
	{
		displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
	}
   private void OnTriggerEnter(Collider other)
    {
		displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
