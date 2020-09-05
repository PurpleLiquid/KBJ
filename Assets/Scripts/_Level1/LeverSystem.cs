using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSystem : MonoBehaviour
{
    [SerializeField] List<Lever> levers;
    [SerializeField] List<bool> leverCombo;
    [SerializeField] Goal goal;

    // Update is called once per frame
    void Update()
    {
        if(Solve())
        {
            goal.End();
        }
    }

    private bool Solve()
    {
        for(int i = 0; i < levers.Count; i++)
        {
            if (levers[i].IsActivated() != leverCombo[i])
            {
                return false;
            }
        }

        return true;
    }
}
