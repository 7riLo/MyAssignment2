/*
 * Levi Wyant
 * Prototype 2
 * helps display score when projectile collides with
 * animal model
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food prefab
public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    //delete object

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
