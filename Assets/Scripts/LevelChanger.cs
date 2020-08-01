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

    public void Fade()
    {
        animator.SetTrigger("FadeOut");
    }

    // ================  Title Screen  ========================
    public void Play()
    {
        print("Pressing Play");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
