using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player playerInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        // Stops duplication
        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
