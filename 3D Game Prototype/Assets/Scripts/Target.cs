using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * 3D Game Prototype
		 * Assignment 5B
		 * This code adds health to objects and when the health goes under zero it destroys it.
		 */

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0 )
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
