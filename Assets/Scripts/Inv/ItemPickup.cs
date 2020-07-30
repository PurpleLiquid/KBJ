using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] Item item;
    
    public void PickUpItem()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Inventory.getInstance().AddItem(item);
            Destroy(gameObject);
        }
    }
}
