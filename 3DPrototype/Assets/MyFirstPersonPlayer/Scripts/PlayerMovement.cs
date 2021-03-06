﻿/*
 * Levi Wyant   
 * 3D Prototype
 * Allows players to use inputs to move player
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;

    //variables for gravity
    public Vector3 velocity;
    public float gravity = -9.8f;
    public float gravityMultiplier = 2f;


    //variables for checking if on ground
    public Transform groundCheck   ;
    public LayerMask groundMaks;
    public float     groundDistance = 0.4f;
    public bool      isGrounded     ;
    public float jumpHeight = 3f;


    private void Awake()
    {
        gravity *= gravityMultiplier; 
        
    }

    void Update()
    {
        //checking if player is on ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMaks);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //get input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
