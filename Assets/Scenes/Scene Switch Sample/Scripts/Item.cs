using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] string itemName;
    [SerializeField] Image icon;

    public Item pickUpItem()
    {
        return this;
    }

    public void useItem()
    {
        Destroy(this);
    }
}
