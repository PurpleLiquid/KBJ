using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] PlayerStateController playerState;

    private ClosableUI[] UIs;

    void Start()
    {
        UIs = Object.FindObjectsOfType<ClosableUI>();
    }

    void Update()
    {
        if (Input.GetKeyDown(ControlConstants.LEAVE_INTERACTION))
        {
            Release();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Release();
    }

    public void Release()
    {
        foreach (ClosableUI UI in UIs)
        {
            UI.CloseUI();
        }

        playerState.setPlayerFree(true);
    }
}
