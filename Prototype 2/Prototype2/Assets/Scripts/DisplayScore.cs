using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;


    void Start()
    {
        textbox = GetComponent<TextElementEnumerator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
