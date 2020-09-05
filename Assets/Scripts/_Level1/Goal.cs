using UnityEngine;

// When using unity editor ifs
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Goal : MonoBehaviour
{
    public void End()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
