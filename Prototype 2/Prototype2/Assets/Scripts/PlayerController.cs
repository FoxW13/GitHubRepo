using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 2
		 * Assignment 3
		 * This code controls the player movement.
		 */

public class PlayerController : MonoBehaviour
{
    public float horiztonalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    void Update()
    {
        horiztonalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horiztonalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
