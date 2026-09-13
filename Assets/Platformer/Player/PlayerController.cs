using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpSpeed = 20f;
    public bool canJump = true;
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
            // look where we're going
            rb.MoveRotation(Quaternion.LookRotation(movement));
            
            // move to a new position
            float moveDistance = moveSpeed * Time.fixedDeltaTime;
            Vector3 scaledMove = movement * moveDistance;
            rb.MovePosition(rb.position + scaledMove);
            
            // set the animation flag
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
