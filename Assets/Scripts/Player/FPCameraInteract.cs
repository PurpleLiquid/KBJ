using UnityEngine;

public class FPCameraInteract : MonoBehaviour
{
    [SerializeField] float range = 2f;
    [SerializeField] InteractTipController tooltip;

    void Update()
    {
        hover();

        // Right-click
        if (Input.GetMouseButtonDown(0)) 
        {
            Interact();
        }
    }

    private void hover()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Interactable interactable = hit.transform.GetComponent<Interactable>();

            if (interactable != null && interactable.enabled == true)
            {
                tooltip.setText(interactable.getTooltipText());
                tooltip.showText(true);
                return;
            }
        }

        tooltip.showText(false);
    }

    private void Interact()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Interactable interactable = hit.transform.GetComponent<Interactable>();

            if(interactable != null && interactable.enabled == true)
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
