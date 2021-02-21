using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockUI : ClosableUI
{
    [SerializeField] List<LockSlot> lockSlots = new List<LockSlot>();
    [SerializeField] List<int> lockComboNumbers;
    private int index = 0;
    private bool solved = false;

    public bool IsSolved()
    {
        return solved;
    }

    private void Awake()
    {
        for (int i = 0; i < lockSlots.Count; i++)
        {
            LockSlot slot = lockSlots[i].GetComponent<LockSlot>();

            if (slot.GetComponent<Outline>() != null)
            {
                slot.GetComponent<Outline>().enabled = false;
            }
        }

        lockSlots[index].GetComponent<Outline>().enabled = true;
    }

    private void Update()
    {
        if (SolveLock())
        {
            solved = true;
        }
    }

    public void ResetLockSelection()
    {
        for (int i = 0; i < lockSlots.Count; i++)
        {
            LockSlot slot = lockSlots[i].GetComponent<LockSlot>();

            if (slot.GetComponent<Outline>() != null)
            {
                slot.GetComponent<Outline>().enabled = false;
            }
        }
    }

    private List<int> GetCurrentLockConfig()
    {
        List<int> lockConfig = new List<int>();
        
        for(int i = 0; i < lockSlots.Count; i++)
        {
            lockConfig.Add(lockSlots[i].GetIndex());
        }

        return lockConfig;
    }

    private bool SolveLock()
    {
        List<int> currentLockConfig = GetCurrentLockConfig();
        int lockSize = lockComboNumbers.Count;

        if(lockSize != currentLockConfig.Count)
        {
            Debug.Log("Lock configurations in inspector is wrong");
            return false;
        }

        for(int i = 0; i < lockSize; i++)
        {
            // lock is wrong
            if(currentLockConfig[i] != lockComboNumbers[i])
            {
                return false;
            }
        }

        // lock is correct
        DisableLocks();
        return true;
    }

    private void DisableLocks()
    {
        for (int i = 0; i < lockSlots.Count; i++)
        {
            lockSlots[i].GetComponent<LockSlot>().enabled = false;
        }
    }
}
