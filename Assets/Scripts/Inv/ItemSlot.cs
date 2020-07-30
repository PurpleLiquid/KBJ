using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    private Item item = null;
    public Image icon;

    public void SetItem(Item newItem)
    {
        Inventory inv = Inventory.getInstance();

        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public bool HasItem()
    {
        return item != null;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
