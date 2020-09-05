using UnityEngine;

public class Lever : Interactable
{
    [SerializeField] bool activated = false;

    public override void Interact()
    {
        activated = !activated;
        print(gameObject.name + " is " + activated);
    }

    public bool IsActivated()
    {
        return activated;
    }
}
