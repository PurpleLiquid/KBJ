using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// When using unity editor ifs
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Dummy : MonoBehaviour
{
    public bool interactable = false;

    public void goal() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            #if UNITY_EDITOR
                // Stops editor from playing
                EditorApplication.isPlaying = false;
            #else
                // When not using Unity Editor close application
                // https://docs.unity3d.com/Manual/PlatformDependentCompilation.html
                Application.Quit();
            #endif
        }
    }
}
