using System.Collections;
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
        ui.gameObject.SetActive(true);
        playerState.setPlayerFree(false);
    }

    public void Release()
    {
        ui.gameObject.SetActive(false);
        playerState.setPlayerFree(true);
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
        if(ui.IsSolved())
        {
            StartCoroutine(unlockGoal());
        }

        if (Input.GetKeyDown(ControlConstants.LEAVE_INTERACTION))
        {
            Release();
        }
    }
}