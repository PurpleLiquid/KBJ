using UnityEngine;
using UnityEngine.UI;

public class Interacter : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;
        
        RaycastHit hit;
        
        // params in order origin, direction, color, duration, depth test
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.red, 0f, false);
        
        // params in order: origin, direction, hitinfo, max distance, layer mask
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1f, layerMask))
        {
            // If door
            if (hit.transform.gameObject.GetComponent<Door>() != null)
            {
                hit.transform.gameObject.GetComponent<Door>().goNextRoom();
            }

            // If Key
            if (hit.transform.gameObject.GetComponent<ItemPickup>() != null)
            {
                hit.transform.gameObject.GetComponent<ItemPickup>().pickUpItem();
            }

            // If Goal
            if (hit.transform.gameObject.GetComponent<GreedyGoal>() != null)
            {
                hit.transform.gameObject.GetComponent<GreedyGoal>().lockedGoal();
            }
        }
    }
}
