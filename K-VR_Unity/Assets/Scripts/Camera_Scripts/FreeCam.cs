using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCam : MonoBehaviour
{

    public float speed = 20f;
    public float sensitivity = 2.5f;


    void Start()
    {
        Screen.lockCursor = true;
    }

    void Update()
    {
        //If user press "A" or "Left Arrow" keys, change transform position vector as -Right * Speed * Delta Time
        if(Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + (-transform.right) * speed * Time.deltaTime;
        }
        //If user press "D" or "Right Arrow" keys, change transform position vector as Right * Speed * Delta Time
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + (transform.right) * speed * Time.deltaTime;
        }
        //If user press "W" or "Up Arrow" keys, change transform position vector as Forward * Speed * Delta Time
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + (transform.forward) * speed * Time.deltaTime;
        }
        //If user press "S" or "Down Arrow" keys, change transform position vector as -Forward * Speed * Delta Time
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + (-transform.forward) * speed * Time.deltaTime;
        }


        //Camera Rotation
        float rotX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        float rotY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * sensitivity;
        transform.localEulerAngles = new Vector3(rotY, rotX, 0f);

    }
}
