using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;

    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        processMovement();
    }

    private void processMovement()
    {
        if (Input.GetButton(ControlConstants.FORWARD_OR_BACKWARD_MOVEMENT)) // left and right movement
        {
            transform.position += Input.GetAxis(ControlConstants.FORWARD_OR_BACKWARD_MOVEMENT) 
                                  * transform.right 
                                  * Time.deltaTime 
                                  * moveSpeed;
        }

        if (Input.GetButton(ControlConstants.LEFT_OR_RIGHT_MOVEMENT)) // Forward and back movement
        {
            transform.position += Input.GetAxis(ControlConstants.LEFT_OR_RIGHT_MOVEMENT) 
                                  * transform.forward 
                                  * Time.deltaTime 
                                  * moveSpeed;
        }

    }
}
