using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// When using unity editor ifs
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GreedyGoal : MonoBehaviour
{
    public void lockedGoal()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Item key = Inventory.getInstance().getItem("Key");

            // Need to make this better
            if (key != null)
            {
                #if UNITY_EDITOR
                // Stops editor from playing
                EditorApplication.isPlaying = false;
                #else
                    Application.Quit();
                #endif
            }
        }
    }
}
