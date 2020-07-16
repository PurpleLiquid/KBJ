using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private List<ItemSlot> itemSlotList;

    private void Start()
    {
        itemSlotList = new List<ItemSlot>();

        foreach (Transform child in transform)
        {
            ItemSlot slot = child.GetComponent<ItemSlot>();
            itemSlotList.Add(slot);
        }

        print(itemSlotList.Count);
    }

    public void addItemVisually(Item item)
    {

    }
}
