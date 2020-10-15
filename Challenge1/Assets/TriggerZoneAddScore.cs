/*
 * Levi Wyant
 * Challenge 1
 * Adds score if player makes it past trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to a trigger zone
public class TriggerZoneAddScore : MonoBehaviour
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