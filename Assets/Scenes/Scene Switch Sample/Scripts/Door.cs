using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public void goNextRoom()
    {
        // Get current Scene
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (sceneName == "Scene One")
            {
                SceneManager.LoadScene("Scene Two");
            }

            if(sceneName == "Scene Two")
            {
                SceneManager.LoadScene("Scene One");
            }
        }
    }
}
