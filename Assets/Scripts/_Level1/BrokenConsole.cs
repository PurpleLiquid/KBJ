using UnityEngine;
using UnityEngine.UI;

public class BrokenConsole : Interactable
{
    [SerializeField] ClosableUI ui;
    [SerializeField] PlayerStateController playerState;

    void Start()
    {
        ui.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        ui.ShowUI();
        playerState.setPlayerFree(false);
    }
}
