using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Challenge 1
		 * Assignment #2
		 * This script sets the gameOver Boolean to true when the player drops below -51 or above 80 on the y axis.
		 */
public class LoseCondition : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
