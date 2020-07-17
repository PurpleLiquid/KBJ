using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    private Item item = null;
    public Image icon;

    public void setItem(Item newItem)
    {
        Inventory inv = Inventory.getInstance();

        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public bool hasItem()
    {
        return item != null;
    }

    public void clearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
