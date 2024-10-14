using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
		 * Fox Weymouth
		 * PennPixel_2DTilemapProject
		 * Assagnment 5A
		 * This code runs the UI, displaying the score and restarting the scene when the game is over.
		 */

public class UIManager : MonoBehaviour
{
    public int score = 0;

    public Text scoreText;

    bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void GameOver()
    {
        gameOver = true;

        scoreText.text = "You Win! Press R to resart";

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
