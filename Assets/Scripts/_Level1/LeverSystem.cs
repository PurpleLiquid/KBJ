using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSystem : MonoBehaviour
{
    [SerializeField] List<Lever> levers;
    [SerializeField] List<bool> leverCombo;
    [SerializeField] LockedDoorGoal goal;

    [SerializeField] string sfxUnlockName;
    [SerializeField] SFXManager sfx;

    // Stops duplication
    private bool sfxPlayed;

    void Start()
    {
        sfxPlayed = false;
    }

    void Update()
    {
        goal.setLocked(isLocked());
    }

    private bool isLocked()
    {
        for(int i = 0; i < levers.Count; i++)
        {
            if (levers[i].IsActivated() != leverCombo[i])
            {
                sfxPlayed = false;
                return true;
            }
        }

        StartCoroutine(PlaySoundDelayed());
        return false;
    }

    private IEnumerator PlaySoundDelayed()
    {
        yield return new WaitForSeconds(1);

        if (sfxPlayed == false)
        {
            sfx.PlaySFX(sfxUnlockName);
            sfxPlayed = true;
        }
    }


}
