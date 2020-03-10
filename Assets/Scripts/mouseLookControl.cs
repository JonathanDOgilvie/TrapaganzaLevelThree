/*Jonathan Ogilvie M00671608
 * DISCLAIMER: Please Invert Mouse Y before executing */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLookControl : MonoBehaviour
{
    public float mSensitivity = 100f;
    public Transform player;
    float xRotation = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //This ensures that we can never fully look behind the player
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Quaternion is responsible for rotation
        player.Rotate(Vector3.up * mouseX);
    }

}//End of Script