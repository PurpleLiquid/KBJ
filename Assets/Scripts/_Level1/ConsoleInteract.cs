using System.Collections;
using UnityEngine;

public class ConsoleInteract : Interactable
{
    [SerializeField] LockUI ui;
    [SerializeField] LockedDoorGoal lockedDoor;

    [SerializeField] UIController uiCont;

    void Start()
    {
        ui.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        // Show lock UI, freeze player
        uiCont.Show(ui);
    }

    private IEnumerator unlockGoal()
    {
        lockedDoor.setLocked(false);
        
        ui.GetComponent<LockUI>().enabled = false;

        yield return new WaitForSeconds(3);

        uiCont.Release();

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