using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

/*
		 * Fox Weymouth
		 * Challenge 2
		 * Assignment 3
		 * This code displays the score on the canvas
		 */

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    public GameObject winText;

    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().gameOver = true;
            winText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
