using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        //pause and show pause menu UI
        if (Input.GetKeyDown(KeyCode.P) & paused == false)
        {
            Time.timeScale = 0f;
            pauseMenuUI.SetActive(true);
            paused = true;
        }

        //unpause and hid pause menu UI
        else if (Input.GetKeyDown(KeyCode.P) & paused == true)
        {
            Time.timeScale = 1f;
            pauseMenuUI.SetActive(false);
            paused = false;

        }
    }
}
