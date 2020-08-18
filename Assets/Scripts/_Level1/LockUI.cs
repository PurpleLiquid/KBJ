using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockUI : MonoBehaviour
{
    private List<LockSlot> lockSlots = new List<LockSlot>();
    private int index = 0;

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
            switchLockLeft();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            switchLockRight();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lockSlots[index].GetComponent<LockSlot>().switchBelowSymbol();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lockSlots[index].GetComponent<LockSlot>().switchUpperSymbol();
        }
    }

    private void switchLockLeft()
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

    private void switchLockRight()
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
}
