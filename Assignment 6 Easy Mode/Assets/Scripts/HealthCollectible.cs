using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Assignment 6 easy mode
		 * Assignment 6
		 * This code adds the collectible that gives health, 
		 * inheriting from collectible and overiding collect.
		 */

public class HealthCollectible : Collectible
{
    private void Awake()
    {
        value = 10;
    }

    public override void Collect()
    {
        base.Collect();
        
        Player.Instance.IncreaseHealth(value);
    }
}
