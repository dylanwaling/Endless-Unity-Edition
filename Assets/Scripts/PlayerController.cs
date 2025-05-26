using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private InputAction moveAction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Get the "Move" action from the project-wide actions asset
        moveAction = InputSystem.actions.FindAction("Player/Move");
        moveAction.Enable();
    }

    void Update()
    {
        // Read the movement vector from the input action
        movement = moveAction.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}