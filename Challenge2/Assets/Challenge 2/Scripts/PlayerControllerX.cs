using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Levi Wyant
 * Prototype 2
 * Controller commands to player go here
 */
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
