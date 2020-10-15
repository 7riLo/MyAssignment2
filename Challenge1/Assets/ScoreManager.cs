/*
 * Levi Wyant
 * Challenge 1
 * Keeps score and updates text to win/ loss conditions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;
    // Update is called once per frame

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }
    void Update()
    {
        //if game not over display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition 3 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }


        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\n Press R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose\n Press R to Try Again!";
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }



    }
}
