﻿/*
 * Levi Wyant
 * Prototype 2
 * controls for player objects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //want to move player left and right
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

   

    // Update is called once per frame
    void Update()
    {
        //Get horizontal input from right and left arrow keys
        horizontalInput = Input.GetAxis("Horizontal");

        //transform horizontally with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
