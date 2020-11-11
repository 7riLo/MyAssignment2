/*
 * Levi Wyant
 * Prototype 4
 * Display Wave number
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWave : MonoBehaviour
{
    public Text textbox;
    public int wave = 1;
    // Start is called before the first frame update
    void Start()
    {
        //set text component on start
        textbox = GetComponent<Text>();
        textbox.text = "Wave: 1";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Wave: " + wave;
        /*
        while (wave > 10)
        {
            textbox.text = "Wave: " + wave;
        }

        //add way to detect 
        
        if(wave < 10)
        {
            textbox.text = "You Lose! Press R to restart!";
        }
        if(wave > 10)
        {
            textbox.text = "You Win! Press R to restart! ";
        }*/
    }

    public void NextWave(int waveNum)
    {
        wave = waveNum;
    }
}
