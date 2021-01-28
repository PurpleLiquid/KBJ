using UnityEngine;
using UnityEngine.UI;

public class InteractTipController : MonoBehaviour
{
    [SerializeField] Text tooltipText;

    private string text;

    void Start()
    {
        tooltipText.gameObject.SetActive(false);
    }

    public void setText(string _text)
    {
        text = _text;
        tooltipText.text = text;
    }

    public void showText(bool showingText)
    {
        tooltipText.gameObject.SetActive(showingText);
    }
}
