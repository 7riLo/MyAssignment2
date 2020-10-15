/*
 * Levi Wyant
 * Challenge 1
 * Player loses if they fall off course
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attach script to player
public class LoseOnFall : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
