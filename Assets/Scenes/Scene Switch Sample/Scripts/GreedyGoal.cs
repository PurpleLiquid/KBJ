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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Will change this later
            if (true)
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
