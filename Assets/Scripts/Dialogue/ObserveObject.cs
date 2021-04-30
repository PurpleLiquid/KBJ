using UnityEngine;

public class ObserveObject : Interactable
{
    [SerializeField] DialogueTrigger trigger;
    [SerializeField] DialogueManager dialogueManager;

    public override void Interact()
    {
        dialogueManager.StartDialogue(trigger.dialogue);
    }
}
