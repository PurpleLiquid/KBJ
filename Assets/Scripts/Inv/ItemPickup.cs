using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] Item item;
    
    public void pickUpItem()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Inventory.getInstance().addItem(item);
            Destroy(gameObject);
        }
    }
}
