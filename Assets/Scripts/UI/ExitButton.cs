using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] ConsoleInteract loackedDoorController;

    public void ExitLock()
    {
        loackedDoorController.Release();
    }
}
