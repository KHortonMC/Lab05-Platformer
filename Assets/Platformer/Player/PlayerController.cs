using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Animator animator;
    private Vector2 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        // Convert 2D input into a 3D movement direction
        Vector3 movement = new Vector3(
            moveInput.x,
            0f,
            moveInput.y
        );

        if (movement != Vector3.zero) { 
            rb.MoveRotation(Quaternion.LookRotation(movement)); 
        }

        animator.SetBool("Walk", movement != Vector3.zero);

        // Move the Rigidbody
        rb.MovePosition(
            rb.position + moveSpeed * Time.fixedDeltaTime * movement
        );
    }
}
