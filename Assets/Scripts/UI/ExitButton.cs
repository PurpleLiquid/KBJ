using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] LockedDoor door;

    public void ExitLock()
    {
        door.Release();
    }
}
