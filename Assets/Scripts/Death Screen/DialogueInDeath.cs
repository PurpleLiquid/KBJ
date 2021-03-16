using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueInDeath : MonoBehaviour
{
    [SerializeField] DialogueManagerOfTheDead dm;
    [SerializeField] DialogueTrigger trigger;

    [SerializeField] Button restartButton;

    void Start()
    {
        restartButton.gameObject.SetActive(false);
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
        if (Input.GetKeyDown(ControlConstants.CONTINUE) || Input.GetMouseButtonDown(0))
        {
            if (dm.DisplayNextSentence() == false)
            {
                restartButton.gameObject.SetActive(true);
            }
        }
    }
}
