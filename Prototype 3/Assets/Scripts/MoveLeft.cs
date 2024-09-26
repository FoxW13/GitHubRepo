using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 3
		 * Assignment 4
		 * This script moves the obstacles left and destroys them when they reach a certain point to the left.
		 */

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;

    private PlayerController playerControllerScript;

    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
