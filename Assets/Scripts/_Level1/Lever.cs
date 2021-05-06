using UnityEngine;

public class Lever : Interactable
{
    [SerializeField] bool activated = false;
    [SerializeField] string sfxName = "";
    [SerializeField] SFXManager sfx;

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
    
    public void PlayLeverPullSound()
    {
        sfx.PlaySFX(sfxName);
    }
}
