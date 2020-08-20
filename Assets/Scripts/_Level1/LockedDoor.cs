using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script should attach to a door
public class LockedDoor : Interactable
{
    [SerializeField] Transform player;
    [SerializeField] Camera fpCam;
    [SerializeField] Image reticle;
    [SerializeField] LockUI ui;
    [SerializeField] Animator doorAnimator;

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
        // Disable player ,free cursor, and start activate lock script
        ui.gameObject.SetActive(true);
        pm.enabled = false;
        fpC.enabled = false;
        fpCI.enabled = false;
        reticle.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if(ui.IsSolved())
        {
            ui.gameObject.SetActive(false);
            pm.enabled = true;
            fpC.enabled = true;
            fpCI.enabled = true;
            reticle.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;

            doorAnimator.SetTrigger("DoorOpen");
            this.enabled = false;
        }
    }
}