using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Need dialogue during the tutorial
 * Has to activate at start of scene
 */
public class Tutorial : MonoBehaviour
{
    [SerializeField] DialogueManager dm;
    [SerializeField] DialogueTrigger tutorialDialogue;

    void Start()
    {
        dm.StartDialogue(tutorialDialogue.dialogue);
    }

    void Update()
    {
        // Right Enter key on windows
        if(Input.GetKeyDown(KeyCode.Return))
        {
            dm.DisplayNextSentence();
        }
    }
}
