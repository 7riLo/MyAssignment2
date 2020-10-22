using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;
    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        //get mouse input and assign to float
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //float mouseZ = Input.GetAxis("Mouse Z") * mouseSensitivity * Time.deltaTime;

        //Rotate player GameObject with horitzontal mouse inpt
        player.transform.Rotate(Vector3.up * mouseX);

        //Rotate the camera around the x axis with verital mouse inpt
        verticalLookRotation -= mouseY;
        //Clamp rotation: limit vertical rotation
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        //apply rotation to camera based on clamp output
        transform.localRotation = Quaternion.Euler(verticalLookRotation,0f,0f);





    }
}
