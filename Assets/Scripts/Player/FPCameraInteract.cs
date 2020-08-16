using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCameraInteract : MonoBehaviour
{
    [SerializeField] float range = 5f;

    void Update()
    {
        // Right-click
        if (Input.GetMouseButtonDown(0)) 
        {
            Interact();
        }
    }

    private void Interact()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Interactable interactable = hit.transform.GetComponent<Interactable>();

            if(interactable != null)
            {
                interactable.Interact();
            }
        }
        else
        {
            return;
        }
    }
}
