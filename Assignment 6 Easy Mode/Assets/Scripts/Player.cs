using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Assignment 6 easy mode
		 * Assignment 6
		 * This code handles the interactions with the player and the collectible.
		 */


public class Player : MonoBehaviour
{
    public static Player Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();
        }
    }

    public void IncreaseHealth(int amount)
    {
        Debug.Log("Increased Health by " + amount);
    }

    public void AddScore(int points)
    {
        Debug.Log("Added Score: " + points);
    }
}
