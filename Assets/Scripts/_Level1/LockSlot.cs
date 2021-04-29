using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockSlot : MonoBehaviour
{
    [SerializeField] List<Sprite> lockSymbols;

    private SFXManager sfx;

    // The first symbol in the list will be the first shown symbol
    private int index = 0;

    private void Start()
    {
        Image image = transform.GetComponent<Image>();

        GameObject scripts = GameObject.Find("Scripts");
        sfx = scripts.GetComponent<SFXManager>();

        if(lockSymbols.Count > 0)
        {
            image.sprite = lockSymbols[index];
        }
    }

    private void Update()
    {
        if(gameObject.GetComponent<Outline>().enabled == true)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0f) // Scroll down
            {
                SwitchBelowSymbol();
            }
            else if (Input.GetAxis("Mouse ScrollWheel") > 0f) // Scroll up
            {
                SwitchUpperSymbol();
            }
        }
    }

    private void SwitchUpperSymbol()
    {
        if(index == 0)
        {
            index = (lockSymbols.Count - 1);
        }
        else
        {
            index--;
        }

        Image image = transform.GetComponent<Image>();
        image.sprite = lockSymbols[index];

        sfx.PlaySFX("Lock_Switch");
    }

    private void SwitchBelowSymbol()
    {
        if (index == (lockSymbols.Count - 1))
        {
            index = 0;
        }
        else
        {
            index++;
        }

        Image image = transform.GetComponent<Image>();
        image.sprite = lockSymbols[index];

        sfx.PlaySFX("Lock_Switch");
    }

    public void SetAsSelected()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public int GetIndex()
    {
        return index;
    }
}
