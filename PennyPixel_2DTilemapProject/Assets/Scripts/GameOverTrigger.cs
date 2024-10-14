using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * PennPixel_2DTilemapProject
		 * Assagnment 5A
		 * This code runs the the win trigger zone and ends the game when collided with.
		 */

public class GameOverTrigger : MonoBehaviour
{

    public UIManager scoreMan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D theCollider)
    {
        scoreMan.GameOver();
    }
}
