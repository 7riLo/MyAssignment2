/*
 * Levi Wyant
 * 2D Prototype
 * Display the score via text box script
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngineInternal;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //set text component on start
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
        if(score >= 13)
        {
            textbox = GetComponent<Text>();
            textbox.text = "You Win!";
        }
    }
}
