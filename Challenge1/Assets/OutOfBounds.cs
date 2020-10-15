/*
 * Levi Wyant
 * Challenge 1
 * Player loses if they go out of bounds.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attach script to player
public class OutOfBounds : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //if player goes past -51 or 80 they lose
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
