using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] string interactTooltipText = "Interact";

    public abstract void Interact();

    public string getTooltipText()
    {
        return interactTooltipText;
    }
}
