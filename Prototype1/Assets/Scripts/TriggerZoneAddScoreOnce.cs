using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 1
		 * Assignment #2
		 * This script lets the trigger zone dectect the player instead of the player detecting the triggerzone
		 */
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
	private bool triggered = false;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") && !triggered)
		{
			triggered = true;
			ScoreManager.score++;
		}
	}
}
