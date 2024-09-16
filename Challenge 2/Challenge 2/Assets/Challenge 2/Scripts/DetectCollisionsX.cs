using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Challenge 2
		 * Assignment 3
		 * This code destroys the ball on collision and increments the score by 1.
		 */ 
public class DetectCollisionsX : MonoBehaviour
{
	private DisplayScore displayScoreScript;

	private void start()
	{
		displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
	}
    private void OnTriggerEnter(Collider other)
    {
		displayScoreScript.score++;
        Destroy(gameObject);
    }

}
