using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LockedDoorGoal : Interactable
{
    [SerializeField] bool locked = true;
    [SerializeField] LevelChanger fadeUI;
    [SerializeField] string nextSceneName = "";

    [SerializeField] Text actionText;

    void Start()
    {
        actionText.text = "Door is Locked";
        actionText.gameObject.SetActive(false);
    }

    public void setLocked(bool isLocked)
    {
        locked = isLocked;
    }

    public override void Interact()
    {
        if (locked == false)
        {
            transform.GetComponent<Animator>().SetTrigger("Open");
            StartCoroutine(nextLevelDelay());
        }
        else
        {
            StartCoroutine(showLockedTip());
        }
    }

    private IEnumerator showLockedTip()
    {
        actionText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);

        actionText.gameObject.SetActive(false);
    }

    private IEnumerator nextLevelDelay()
    {
        yield return new WaitForSeconds(2);
        fadeUI.setNextScene(nextSceneName);
        fadeUI.Fade();

        yield return new WaitForSeconds(2);
        fadeUI.PlayNextScene();
    }
}
