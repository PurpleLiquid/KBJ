using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject inventory;
    private bool access = false;

    void Start()
    {
        // Just in case
        inventory.SetActive(false);
    }
    
    void Update()
    {
        // Accessing Inventory
        if (Input.GetKeyDown(KeyCode.I) & access == true)
        {
            inventory.SetActive(false);
            access = false;
        }
        else if(Input.GetKeyDown(KeyCode.I) & access == false)
        {
            inventory.SetActive(true);
            access = true;
        }
    }
}
