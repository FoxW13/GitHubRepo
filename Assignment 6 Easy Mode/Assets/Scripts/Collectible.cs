using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Assignment 6 easy mode
		 * Assignment 6
		 * This code is the base class for the collectible that implements the ICollectibles.
		 */

public abstract class Collectible : MonoBehaviour, ICollectible
{
    protected int value;

    public virtual void Collect()
    {
        Debug.Log("Collected item!");
        Destroy(gameObject); 
    }

    public int GetValue()
    {
        return value; 
    }
}
