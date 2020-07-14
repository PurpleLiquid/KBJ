using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : MonoBehaviour
{
    public string itemName = "New Item";
    public Sprite icon = null;
    
    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
