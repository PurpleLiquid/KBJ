using System.Collections;
using UnityEngine;

public class LockedDoorGoal : Interactable
{
    [SerializeField] bool locked = true;
    [SerializeField] LevelChanger fadeUI;
    [SerializeField] string nextSceneName = "";

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
