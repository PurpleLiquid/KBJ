using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
        if (Input.GetButton("Horizontal")) // left/right movement; a/d 
        {
            transform.position += Input.GetAxis("Horizontal") * transform.right * Time.deltaTime * moveSpeed;
        }

        if(Input.GetButton("Vertical")) // forward/back movement; w/s
        {
            transform.position += Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * moveSpeed;
        }

        if (Input.GetButton("Rotation")) // Rotate player to change where it's looking; q/e
        {
            transform.Rotate(0, Input.GetAxis("Rotation") * Time.deltaTime * rotateSpeed, 0);
        }

        /* Another way for movement
        float horizontal = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
        */
    }
}
