using UnityEngine;

public class FPCamera : MonoBehaviour
{
    [SerializeField] float lookSpeed = 500f;
    [SerializeField] Transform target;

    private float clampRotation = 0f;
    
    void Start()
    {
        //lock cursor to screen center
        Cursor.lockState = CursorLockMode.Locked;

        //move camera to player's first person view
        transform.position = target.position;

    }
    
    void LateUpdate()
    {
        firstPerson();
    }

    //  Rotates camera on x and y axis, rotates player on x axis 
    private void firstPerson()
    {
        float xAxis = Input.GetAxis("Mouse X") * lookSpeed * Time.deltaTime;
        float yAxis = Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime;

        clampRotation -= yAxis;
        clampRotation = Mathf.Clamp(clampRotation, -90f, 90f);

        //x-axis rotation
        target.Rotate(Vector3.up * xAxis);

        //y-axis rotation
        //transform.Rotate(Vector3.left * yAxis);
        transform.localRotation = Quaternion.Euler(clampRotation, 0f, 0f);

    }
}
