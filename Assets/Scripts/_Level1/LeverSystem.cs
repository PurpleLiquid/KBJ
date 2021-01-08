using System.Collections.Generic;
using UnityEngine;

public class LeverSystem : MonoBehaviour
{
    [SerializeField] List<Lever> levers;
    [SerializeField] List<bool> leverCombo;
    [SerializeField] LockedDoorGoal goal;

    // Update is called once per frame
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
                return true;
            }
        }

        return false;
    }
}
