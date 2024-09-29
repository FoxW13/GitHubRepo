using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * Challenge 3
		 * Assignment 4
		 * This script allows the player to move up by pressing space, doesnt let the player go up if the balloon goes too high, has all the audio, and controlls what all the collisions do.
		 */

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;
    public bool isLowEnough = true;

    private UIManager manager;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip groundSound;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<UIManager>();

        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > 13 )
        {
            isLowEnough = false;
        } else
        {
            isLowEnough = true;
        }

        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && isLowEnough)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            manager.score++;

            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

        else if (other.gameObject.CompareTag("Ground"))
        {
            playerAudio.PlayOneShot(groundSound, 1.0f);
            playerRb.AddForce(Vector3.up * 5f, ForceMode.Impulse); ;
        }

    }

}
