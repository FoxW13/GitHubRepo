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


    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
