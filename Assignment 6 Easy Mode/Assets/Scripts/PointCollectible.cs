using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Assignment 6 easy mode
		 * Assignment 6
		 * This code adds the collectible that gives points, 
		 * inheriting from collectible and overiding collect.
		 */

public class PointCollectible : Collectible
{
    private void Awake()
    {
        value = 5; // Set points value
    }

    public override void Collect()
    {
        base.Collect();
        // Additional behavior: increase player score
        Player.Instance.AddScore(value);
    }
}
