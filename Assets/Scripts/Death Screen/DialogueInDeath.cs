using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInDeath : MonoBehaviour
{
    [SerializeField] DialogueManagerOfTheDead dm;
    [SerializeField] DialogueTrigger trigger;

    void Start()
    {
        StartCoroutine(LateStart());
    }

    private IEnumerator LateStart()
    {
        yield return new WaitForSeconds(1);
        dm.StartDialogue(trigger.dialogue);
    }

    void Update()
    {
        // Right Enter key on windows
        if (Input.GetKeyDown(ControlConstants.CONTINUE))
        {
            dm.DisplayNextSentence();
        }
    }
}
