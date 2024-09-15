using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 2
		 * Assignment 3
		 * This code makes the animals and food move forward.
		 */

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
