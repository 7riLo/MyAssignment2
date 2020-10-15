/*
 * Levi Wyant
 * Challenge 1
 * rotates propellor object
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate z axis
        transform.Rotate(Vector3.forward, 50);
    }
}
