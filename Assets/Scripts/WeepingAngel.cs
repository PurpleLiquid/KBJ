using UnityEngine;
using UnityEngine.AI;

public class WeepingAngel : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float visionRange = 7.5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool move;
    Renderer renderer;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        move = false;
        renderer = GetComponent<Renderer>();
    }
    
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        
        if(renderer.isVisible)
        {
            move = false;
        }

        if(!renderer.isVisible)
        {
            move = true;
        }

        processMovement();
    }

    private void processMovement()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (move && distanceToTarget <= visionRange)
        {
            navMeshAgent.isStopped = false;
            navMeshAgent.SetDestination(target.position);
        }
        else
        {
            navMeshAgent.isStopped = true;
        }
    }

    // Creates vision field when object is selected in scene view
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, visionRange);
    }
}
