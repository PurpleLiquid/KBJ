using UnityEngine;
using UnityEngine.AI;

public class Pusher : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float visionRange = 10f;
    [SerializeField] float aggroRange = 7f;

    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private float distanceToTarget = Mathf.Infinity;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= visionRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, visionRange);
    }
}
