using UnityEngine;

public class ClosableUI : MonoBehaviour
{
    public void CloseUI()
    {
        gameObject.SetActive(false);
    }

    public void ShowUI()
    {
        gameObject.SetActive(true);
    }
}
