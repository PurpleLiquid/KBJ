using UnityEngine;

public class ItemPickup : Interactable
{
    [SerializeField] Item item;
    
    public override void Interact()
    {
        Inventory.getInstance().AddItem(item);
        Destroy(gameObject);
    }
}
