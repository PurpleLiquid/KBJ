using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] PlayerStateController playerState;

    private ClosableUI activeUI;

    void Start()
    {
        gameObject.SetActive(false);
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
        activeUI.CloseUI();
        playerState.setPlayerFree(true);
        gameObject.SetActive(false);
    }

    public void Show(ClosableUI ui)
    {
        activeUI = ui;
        activeUI.ShowUI();
        playerState.setPlayerFree(false);
        gameObject.SetActive(true);
    }
}
