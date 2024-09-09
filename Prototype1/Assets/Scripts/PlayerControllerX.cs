using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 1
		 * Assignment #2
		 * This script allows the ability to change the movement and turning speed of the player.
		 */ 
public class PlayerControllerX : MonoBehaviour
{

    public float speed;
    public float turnSpeed;

    public float forwardInput;
    public float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
