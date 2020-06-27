using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{

    // Start is called before the first frame update
    public static bool paused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        //pause
        if (Input.GetKeyDown(KeyCode.P) & paused == false)
        {

            Time.timeScale = 0f;
            paused = true;
            pauseMenuUI.SetActive(true);
            print(Time.timeScale);
        }

        //unpause
        else if (Input.GetKeyDown(KeyCode.P) & paused == true)
        {
            Time.timeScale = 1f;
            paused = false;
            pauseMenuUI.SetActive(false);
            print(Time.timeScale);
        }

        
            
         
            
        
        

    }
}
