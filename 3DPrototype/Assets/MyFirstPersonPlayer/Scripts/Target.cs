/*
 * Levi Wyant   
 * 3D Prototype
 * Allows for objects to be destroyed
*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }
        void Die()
        {
            Destroy(gameObject);
        }
    }
}
