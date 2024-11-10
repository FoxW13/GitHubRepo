using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Assignment 6 easy mode
		 * Assignment 6
		 * This code is the behavior required for the collectible items, 
		 * begin the collection behavoir and the collections value.
		 */

public interface ICollectible
    {
        void Collect(); 
        int GetValue(); 
    }
