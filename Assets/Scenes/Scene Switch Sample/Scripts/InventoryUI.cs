using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private List<ItemSlot> itemSlotList;

    private void Start()
    {
        foreach(Transform child in transform)
        {
            ItemSlot slot = child.GetComponent<ItemSlot>();
            itemSlotList.Add(slot);
        }
    }

    public void addItemVisually(Item item)
    {

    }
}
