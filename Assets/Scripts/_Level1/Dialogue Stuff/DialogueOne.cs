using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOne : MonoBehaviour
{
    [SerializeField] DialogueManager dm;
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
}
