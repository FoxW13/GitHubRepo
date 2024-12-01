using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
         *Fox Weymouth
         * Challenge 5
		 * Assignment 8
		 * This code runs the destroy function.
		 */

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
