using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockSlot : MonoBehaviour
{
    [SerializeField] List<Sprite> lockSymbols;

    // The first symbol in the list will be the first shown symbol
    private int index = 0;

    private void Start()
    {
        Image image = transform.GetChild(0).GetComponent<Image>();
        image.sprite = lockSymbols[index];
    }

    public void SwitchUpperSymbol()
    {
        if(index == 0)
        {
            index = (lockSymbols.Count - 1);
        }
        else
        {
            index--;
        }

        Image image = transform.GetChild(0).GetComponent<Image>();
        image.sprite = lockSymbols[index];
    }

    public void SwitchBelowSymbol()
    {
        if (index == (lockSymbols.Count - 1))
        {
            index = 0;
        }
        else
        {
            index++;
        }

        Image image = transform.GetChild(0).GetComponent<Image>();
        image.sprite = lockSymbols[index];
    }

    public int GetIndex()
    {
        return index;
    }
}
