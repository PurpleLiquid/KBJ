using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton
public class Inventory : MonoBehaviour
{
    private static Inventory _instance;

    public static Inventory getInstance()
    {
        return _instance;
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
            _instance = this;
        }
    }
}
