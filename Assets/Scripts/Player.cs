using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 movementInput;
    public float moveSpeed = 5f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        InputReader.OnMovement += HandleMovement;
    }

    void OnDisable()
    {
        InputReader.OnMovement -= HandleMovement;
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(movementInput.x, rb.linearVelocity.y, movementInput.y);
        rb.linearVelocity = move * moveSpeed;
    }
    public void HandleMovement(Vector2 input)
    {
        movementInput = input;
    }
}
