/*
 * Levi Wyant
 * Prototype 2
 * Makes sure prefabs are destroyed when 
 * no longer needed in the scene or out of scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    //fixed, added negative
    private float leftLimit = -30;
    private float bottomLimit = -5;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        //fixed changed to less than
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            //grab take damage script
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }

    }
}
