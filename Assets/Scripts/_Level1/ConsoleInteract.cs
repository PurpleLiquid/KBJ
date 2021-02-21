﻿using System.Collections;
using UnityEngine;

public class ConsoleInteract : Interactable
{
    [SerializeField] LockUI ui;
    [SerializeField] PlayerStateController playerState;
    [SerializeField] LockedDoorGoal lockedDoor;

    void Start()
    {
        ui.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        // Show lock UI, freeze player
        ui.ShowUI();
        playerState.setPlayerFree(false);
    }

    private IEnumerator unlockGoal()
    {
        lockedDoor.setLocked(false);
        
        ui.GetComponent<LockUI>().enabled = false;

        yield return new WaitForSeconds(3);

        ui.gameObject.SetActive(false);
        playerState.setPlayerFree(true);

        this.enabled = false;
    }

    void Update()
    {
        if (ui.IsSolved())
        {
            StartCoroutine(unlockGoal());
        }
    }
}