using UnityEngine;
using UnityEngine.UI;

// This script should attach to a door
public class LockedDoor : Interactable
{
    [SerializeField] LockUI ui;
    [SerializeField] Transform player;
    [SerializeField] Camera fpCam;
    [SerializeField] Image reticle;

    private PlayerMovement pm;
    private FPCamera fpC;
    private FPCameraInteract fpCI;

    void Start()
    {
        ui.gameObject.SetActive(false);
        pm = player.GetComponent<PlayerMovement>();
        fpC = fpCam.GetComponent<FPCamera>();
        fpCI = fpCam.GetComponent<FPCameraInteract>();
    }

    public override void Interact()
    {
        // Disable player and free cursor
        ui.gameObject.SetActive(true);
        pm.enabled = false;
        fpC.enabled = false;
        fpCI.enabled = false;
        reticle.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
}