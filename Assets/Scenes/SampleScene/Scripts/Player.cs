using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;
    [SerializeField] float rotateSpeed = 100f;

    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processMovement();
    }

    private void processMovement()
    {
        if (Input.GetButton("Horizontal")) // left and right movement
        {
            transform.position += Input.GetAxis("Horizontal") * transform.right * Time.deltaTime * moveSpeed;
        }

        if(Input.GetButton("Vertical")) // Forward and back movement
        {
            transform.position += Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * moveSpeed;
        }

        if (Input.GetButton("Rotation")) // Rotate player to change where it's looking
        {
            transform.Rotate(0, Input.GetAxis("Rotation") * Time.deltaTime * rotateSpeed, 0);
        }
    }
}
