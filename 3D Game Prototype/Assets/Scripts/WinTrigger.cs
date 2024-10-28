using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
		 * Fox Weymouth
		 * 3D Game Prototype
		 * Assignment 5B
		 * This code runs the win trigger zone so when the player collides with it it displays the win text.
		 */


public class WinTrigger : MonoBehaviour
{
    public Text winText;

    private void Start()
    {
        winText.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.enabled=true;
        }
    }
}
