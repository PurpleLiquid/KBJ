using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockUI : MonoBehaviour
{
    private List<LockSlot> lockSlots = new List<LockSlot>();
    [SerializeField] List<int> lockComboNumbers;
    private int index = 0;
    private bool solved = false;

    public bool IsSolved()
    {
        return solved;
    }

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            LockSlot slot = child.GetComponent<LockSlot>();

            if (slot.GetComponent<Outline>() != null)
            {
                slot.GetComponent<Outline>().enabled = false;
            }

            lockSlots.Add(slot);
        }

        lockSlots[index].GetComponent<Outline>().enabled = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SwitchLockLeft();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            SwitchLockRight();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lockSlots[index].GetComponent<LockSlot>().SwitchBelowSymbol();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lockSlots[index].GetComponent<LockSlot>().SwitchUpperSymbol();
        }

        if (SolveLock())
        {
            solved = true;
        }
    }

    private void SwitchLockLeft()
    {
        lockSlots[index].GetComponent<Outline>().enabled = false;

        if(index == 0)
        {
            index = (lockSlots.Count - 1);
        }
        else
        {
            index--;
        }

        lockSlots[index].GetComponent<Outline>().enabled = true;
    }

    private void SwitchLockRight()
    {
        lockSlots[index].GetComponent<Outline>().enabled = false;

        if (index == (lockSlots.Count-1))
        {
            index = 0;
        }
        else
        {
            index++;
        }

        lockSlots[index].GetComponent<Outline>().enabled = true;
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
        return true;
    }
}
