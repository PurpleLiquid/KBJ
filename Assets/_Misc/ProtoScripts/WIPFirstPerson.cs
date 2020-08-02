﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIPFirstPerson : MonoBehaviour
{
    public float lookSpeed = 500f;
    public bool thirdPersonMode = false;
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //lock cursor to screen center
        Cursor.lockState = CursorLockMode.Locked;

        //move camera to player's first person view
        transform.position = target.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        firstPerson();
    }

    //  Rotates camera on x and y axis, rotates player on x axis 
    private void firstPerson()
    {
        //x-axis rotation
        target.Rotate(Vector3.up * Input.GetAxis("Mouse X") * lookSpeed * Time.deltaTime);

        //y-axis rotation
        transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime);

    }


    

}