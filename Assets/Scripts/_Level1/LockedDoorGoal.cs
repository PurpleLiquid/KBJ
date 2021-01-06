using System.Collections;
using UnityEngine;

public class LockedDoorGoal : Interactable
{
    [SerializeField] bool locked = true;
    [SerializeField] LevelChanger fadeUI;

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
        fadeUI.FloorOneNext();
        fadeUI.Fade();

        yield return new WaitForSeconds(2);
        fadeUI.PlayNextScene();
    }
}
