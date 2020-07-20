using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public float lookSpeed = 600f;
    public bool thirdPersonMode = false;
    [SerializeField] Transform target;
    //[SerializeField] Transform firstPersonPos;
    //[SerializeField] Transform thirdPersonPos;

  

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //>offset = target.transform.position - transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        transform.position = target.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        firstPerson();


        }

    private void firstPerson()
    {
        
        target.Rotate(Vector3.up * Input.GetAxis("Mouse X") * lookSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime);

    }


    

}
