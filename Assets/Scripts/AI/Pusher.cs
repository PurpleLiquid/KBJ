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

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= visionRange)
        {
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
        navMeshAgent.SetDestination(originPos);

        if(transform.position.z == originPos.z)
        {
            animator.SetBool("Idle", true);
        }
    }

    public void CheckVisionAfterCharge()
    {
        if (targetBeforeChargePos.z == transform.position.z)
        {
            if ((distanceToTarget <= visionRange) == false)
            {
                animator.SetBool("InRange", false);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, visionRange);
    }
}
