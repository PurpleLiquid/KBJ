using UnityEngine;
using UnityEngine.AI;

public class Pusher : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float visionRange = 10f;

    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private float distanceToTarget = Mathf.Infinity;
    private Vector3 originPos;
    private Vector3 targetBeforeChargePos;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        originPos = transform.position;
        navMeshAgent.isStopped = true;
    }
    
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= visionRange)
        {
            navMeshAgent.isStopped = false;
            animator.SetBool("InRange", true);
            animator.SetBool("Idle", false);
            targetBeforeChargePos = target.position;
        }
    }

    public void ChargePlayer()
    {
        navMeshAgent.SetDestination(targetBeforeChargePos);
    }

    public void ReturnToOrigin()
    {
        navMeshAgent.isStopped = false;
        navMeshAgent.SetDestination(originPos);

        if((transform.position.z - 0.1) <= originPos.z)
        {
            animator.SetBool("Idle", true);
            navMeshAgent.isStopped = true;
        }
    }

    public void CheckVisionAfterCharge()
    {
        if ((distanceToTarget <= visionRange) == false)
        {
            navMeshAgent.SetDestination(transform.position);
            animator.SetBool("InRange", false);
        }
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, visionRange);
    }
}
