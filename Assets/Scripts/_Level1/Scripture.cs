using UnityEngine;

public class Scripture : Interactable
{
    [SerializeField] ClosableUI ui;
    [SerializeField] UIController uiCont;

    private void Start()
    {
        ui.CloseUI();
    }

    public override void Interact()
    {
        uiCont.Show(ui);
    }
}
