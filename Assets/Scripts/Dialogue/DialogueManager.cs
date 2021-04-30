using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences = new Queue<string>();
    [SerializeField] Text nameText;
    [SerializeField] Text dialogueText;

    // The white box thingy
    [SerializeField] Image dialogueBox;

    [SerializeField] PlayerStateController playerState;

    public void StartDialogue(Dialogue dialogue)
    {
        playerState.setPlayerFree(false);
        sentences.Clear();

        nameText.text = dialogue.name;
        dialogueBox.gameObject.SetActive(true);

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        // Outputs the first sentence
        DisplayNextSentence();
    }

    public bool DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return false;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        return true;
    }

    private void EndDialogue()
    {
        dialogueBox.gameObject.SetActive(false);
        playerState.setPlayerFree(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(ControlConstants.CONTINUE) || Input.GetMouseButtonDown(0))
        {
            if(dialogueBox.IsActive() == true)
            {
                DisplayNextSentence();
            }
            
        }
    }
}
