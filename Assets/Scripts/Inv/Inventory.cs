using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton
public class Inventory : MonoBehaviour
{
    private static Inventory _instance;
    private List<Item> itemList = new List<Item>();
    private bool accessed = false;

    // For the visual
    [SerializeField] InventoryUI ui;

    public static Inventory getInstance()
    {
        return _instance;
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            // Stops duplication
            Destroy(this.gameObject);
        }
        else
        {
            // This allows it to switch scenes
            DontDestroyOnLoad(this);
            _instance = this;
        }
    }

    private void Start()
    {
        // Just in case
        ui.gameObject.SetActive(false);
    }

    private void Update()
    {
        // Inputs
        if (Input.GetKeyDown(KeyCode.Q) & accessed == false)
        {
            ui.transform.gameObject.SetActive(true);
            accessed = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) & accessed == true)
        {
            ui.transform.gameObject.SetActive(false);
            accessed = false;
        }
    }

    public void AddItem(Item newItem)
    {
        itemList.Add(newItem);

        ui.AddItemVisually(newItem);
    }

    public Item GetItem(string itemName)
    {
        Item item = null;

        for(int i = 0; i < itemList.Count; i++)
        {
            item = itemList[i];

            if(itemName == item.itemName)
            {
                return item;
            }
        }

        // Didn't find it
        return null;
    }

    // This is to check if the UI is active or not
    public bool IsAccessed()
    {
        return accessed;
    }
}
