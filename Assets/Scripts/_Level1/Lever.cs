using UnityEngine;

public class Lever : Interactable
{
    [SerializeField] bool activated = false;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if(activated)
        {
            animator.SetBool("Pushed", activated);
        }
    }

    public override void Interact()
    {
        activated = !activated;
        animator.SetBool("Pushed", activated);
    }

    public bool IsActivated()
    {
        return activated;
    }
}
