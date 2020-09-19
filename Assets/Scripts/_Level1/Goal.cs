using UnityEngine;

// When using unity editor ifs
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Goal : Interactable
{
    [SerializeField] bool unlocked = false;

    private void End()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public override void Interact()
    {
        if(unlocked == true)
        {
            End();
        }
        
    }

    public void setLock(bool isLocked)
    {
        unlocked = isLocked;
    }
}
