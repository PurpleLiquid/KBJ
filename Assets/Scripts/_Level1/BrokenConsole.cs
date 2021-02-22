using UnityEngine;

public class BrokenConsole : Interactable
{
    [SerializeField] ClosableUI brokenLockUI;
    [SerializeField] PlayerStateController playerState;

    [SerializeField] UIController uiCont;

    void Start()
    {
        brokenLockUI.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        uiCont.Show(brokenLockUI);
    }
}
