/*
 * Levi Wyant
 * Challenge 1
 * Adds score when player passes trigger zone
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}

