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

    void Start()
    {
        dialogueBox.transform.gameObject.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();

        nameText.text = dialogue.name;
        dialogueBox.transform.gameObject.SetActive(true);

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        // Outputs the first sentence
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    private void EndDialogue()
    {
        dialogueBox.transform.gameObject.SetActive(false);
    }
}
