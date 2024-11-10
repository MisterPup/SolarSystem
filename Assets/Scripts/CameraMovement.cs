using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speedX = 20.0f;
    public float speedY = 20.0f;
    public float speedZ = 20.0f;
    public float mouseSpeedZ = 200.0f;
    
    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * speedX;
        float translationY = Input.GetAxis("UpDown") * speedY;
        float translationZ = Input.GetAxis("Vertical") * speedZ + Input.mouseScrollDelta.y * mouseSpeedZ;

        translationX *= Time.deltaTime;
        translationY *= Time.deltaTime;
        translationZ *= Time.deltaTime;
        
        transform.Translate(translationX, translationY, translationZ);
    }
}