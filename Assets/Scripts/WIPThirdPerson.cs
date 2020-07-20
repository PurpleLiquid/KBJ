using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIPThirdPerson : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float rotateSpeed = 500f;

    public float damping = 1;
    Vector3 offset;

    void Start()
    {
        
    }

    void LateUpdate()
    {

        target.Rotate(Vector3.up * Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);
    }
}
