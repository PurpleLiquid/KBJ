using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;
    [SerializeField] float rotateSpeed = 100f;
    
    public Camera fpCam;
    public Camera tpCam;
    public bool fpMode;

    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        tpCam.gameObject.SetActive(false);
        fpCam.gameObject.SetActive(true);
        fpMode = true;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        processMovement();
        if (Input.GetKeyDown(KeyCode.M) & fpMode == true)
        {
            tpCam.gameObject.SetActive(true);
            fpCam.gameObject.SetActive(false);
            fpMode = false;
        }

        else if (Input.GetKeyDown(KeyCode.M) & fpMode == false)
        {
            tpCam.gameObject.SetActive(false);
            fpCam.gameObject.SetActive(true);
            fpMode = true;
        }

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

        //if (Input.GetButton("Rotation")) // Rotate player to change where it's looking
        //{
        //    transform.Rotate(0, Input.GetAxis("Rotation") * Time.deltaTime * rotateSpeed, 0);
        //}

        /* Another way for movement
        float horizontal = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
        */
    }
}
