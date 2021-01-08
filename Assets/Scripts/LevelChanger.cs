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

    private string nextSceneName = "";

    public void Fade()
    {
        animator.SetTrigger("FadeOut");
    }

    public void PlayNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void setNextScene(string sceneName)
    {
        nextSceneName = sceneName;
    }

    // ================  Title Screen  ========================
    public void Play()
    {
        nextSceneName = "Level 1 Room 1";
    }

    public void Tutorial()
    {
        nextSceneName = "Tutorial";
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
