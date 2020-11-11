/*
 * Levi Wyant
 * Prototype 2
 * Display health sprites and change 
 * them depending on the status of the health of the 
 * player. This was provided via Canvas
 */

//This script is based on https://www.youtube.com/watch?v=3uyolYVsiWc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Experimental.SceneManagement;

public class GameOverText : MonoBehaviour
{

    public bool gameOver = false;

    public GameObject gameOverText;
    public PlayerController player;

    void Update()
    {

        /*
        if (player.transform.position.y < -7)
        {
            gameOver = true;
            gameOverText.SetActive(true);


            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        */
    }
    
}
