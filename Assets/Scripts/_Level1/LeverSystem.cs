using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSystem : MonoBehaviour
{
    [SerializeField] List<Lever> levers;

    // Update is called once per frame
    void Update()
    {
        if(Solve())
        {
            // open goal door
        }
    }

    private bool Solve()
    {
        return false;
    }
}
