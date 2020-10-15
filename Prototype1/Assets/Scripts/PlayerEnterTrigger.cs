/*
 * Levi Wyant
 * Challenge 1
 * Player passes trigger point
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to player
public class PlayerEnterTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}