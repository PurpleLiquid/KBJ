using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private List<ItemSlot> itemSlotList = new List<ItemSlot>();

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            ItemSlot slot = child.GetComponent<ItemSlot>();
            itemSlotList.Add(slot);
        }
    }

    public void addItemVisually(Item newItem)
    {
        for (int i = 0; i < itemSlotList.Count; i++)
        {
            if(itemSlotList[i].hasItem() == false)
            {
                itemSlotList[i].setItem(newItem);
                i = itemSlotList.Count + 1; // Stop loop
            }
        }
    }
}
