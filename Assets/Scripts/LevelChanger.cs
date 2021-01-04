using UnityEngine;
using UnityEngine.SceneManagement;

// When using unity editor ifs
#if UNITY_EDITOR
using UnityEditor;
#endif


/* ==============================
 * NOTE
 * This script will constantly be changing as more scenes are added in
 * I will find a way to make this scalable --Brian
 */
public class LevelChanger : MonoBehaviour
{
    [SerializeField] Animator animator;

    private string nextScene = "";

    public void Fade()
    {
        animator.SetTrigger("FadeOut");
    }

    public void PlayNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    // ================  Title Screen  ========================
    public void Play()
    {
        nextScene = "Level 1 Room 1";
    }

    public void Tutorial()
    {
        nextScene = "Tutorial";
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // ================  Floor 1 Room 1  ========================
    public void FloorOneNext()
    {
        nextScene = "Level 1 Room 2";
    }
}
