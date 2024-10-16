﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Prototype 1
		 * Assignment #2
		 * Script that has the main camera follow the player
		 */
public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
