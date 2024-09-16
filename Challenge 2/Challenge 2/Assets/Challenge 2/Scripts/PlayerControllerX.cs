using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Challenge 2
		 * Assignment 3
		 * This code sends out the dog prefab when space is pressed and gives the space bar a cool down.
		 */
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 1.0f;
    private float nextAllowedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextAllowedTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            nextAllowedTime = Time.time + cooldownTime;
        }
    }
}
