using UnityEngine;
using UnityEngine.UI;

public class BrokenConsole : Interactable
{
    [SerializeField] Image ui;
    [SerializeField] PlayerStateController playerState;

    void Start()
    {
        ui.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        ui.gameObject.SetActive(true);
        playerState.setPlayerFree(false);
    }

    public void Release()
    {
        ui.gameObject.SetActive(false);
        playerState.setPlayerFree(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(ControlConstants.LEAVE_INTERACTION))
        {
            Release();
        }
    }
}
