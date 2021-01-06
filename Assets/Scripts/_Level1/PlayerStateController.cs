using UnityEngine;
using UnityEngine.UI;

public class PlayerStateController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Camera fpCam;
    [SerializeField] Image reticle;

    private PlayerMovement pm;
    private FPCamera fpC;
    private FPCameraInteract fpCI;

    void Start()
    {
        pm = player.GetComponent<PlayerMovement>();
        fpC = fpCam.GetComponent<FPCamera>();
        fpCI = fpCam.GetComponent<FPCameraInteract>();
    }

    public void setPlayerFree(bool free)
    {
        pm.enabled = free;
        fpC.enabled = free;
        fpCI.enabled = free;
        reticle.enabled = free;

        if (free == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }
}
