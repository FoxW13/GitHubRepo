using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Challenge 1
		 * Assignment #2
		 * This script rotates the propeller around the z axis.
		 */
public class SpinPropellerX : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 10);
    }
}
