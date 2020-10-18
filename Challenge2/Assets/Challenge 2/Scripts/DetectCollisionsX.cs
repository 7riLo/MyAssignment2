/*
 * Levi Wyant
 * Prototype 2
 * detects collision between dog and ball
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
   
    private DisplayScore displayScoreScript;
   
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        displayScoreScript.score++;
    }


   

    
}




