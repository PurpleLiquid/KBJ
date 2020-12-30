using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleInteract : Interactable
{
    [SerializeField] Transform player;
    [SerializeField] Transform door;
    [SerializeField] Camera fpCam;
    [SerializeField] Image reticle;
    [SerializeField] LockUI ui;
    [SerializeField] LevelChanger fadeUI;

    private PlayerMovement pm;
    private FPCamera fpC;
    private FPCameraInteract fpCI;

    private BoxCollider collider;

    void Start()
    {
        ui.gameObject.SetActive(false);
        pm = player.GetComponent<PlayerMovement>();
        fpC = fpCam.GetComponent<FPCamera>();
        fpCI = fpCam.GetComponent<FPCameraInteract>();

        collider = door.GetComponent<BoxCollider>();
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

    public void Release()
    {
        ui.gameObject.SetActive(false);
        pm.enabled = true;
        fpC.enabled = true;
        fpCI.enabled = true;
        reticle.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    IEnumerator WaitRelease()
    {
        ui.GetComponent<LockUI>().enabled = false;

        yield return new WaitForSeconds(5);

        ui.gameObject.SetActive(false);
        pm.enabled = true;
        fpC.enabled = true;
        fpCI.enabled = true;
        reticle.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;

        door.GetComponent<Animator>().SetTrigger("Open");
        collider.enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(3);

        fadeUI.FloorOneNext();
        fadeUI.Fade();

        yield return new WaitForSeconds(3);
        fadeUI.PlayNextScene();
    }

    void Update()
    {
        if(ui.IsSolved())
        {
            StartCoroutine(WaitRelease());
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Release();
        }
    }
}