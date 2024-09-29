using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
		 * Fox Weymouth
		 * Challenge 3
		 * Assignment 4
		 * This script 
		 */

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public PlayerControllerX playerControllerScript;

    public bool won = false;

    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try Again!";
        }

        if (score >= 15)
        {
            playerControllerScript.gameOver = true;
            won = true;

            scoreText.text = "You Win!" + "\n" + "Press R to Try Again!";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }
}
