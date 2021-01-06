using UnityEngine;
using UnityEngine.UI;

public class Scripture : Interactable
{
    [SerializeField] Image scriptureCanvas;
    [SerializeField] PlayerStateController playerController;

    void Start()
    {
        scriptureCanvas.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            scriptureCanvas.gameObject.SetActive(false);
            playerController.setPlayerFree(true);
        }
    }

    public override void Interact()
    {
        scriptureCanvas.gameObject.SetActive(true);
        playerController.setPlayerFree(false);
    }
}
