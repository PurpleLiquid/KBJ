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
        if (Input.GetButton("Horizontal")) // left and right movement
        {
            transform.position += Input.GetAxis("Horizontal") * transform.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetButton("Vertical")) // Forward and back movement
        {
            transform.position += Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * moveSpeed;
        }

    }
}
