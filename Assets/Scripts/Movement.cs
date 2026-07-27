using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    Rigidbody rb;
    Vector2 move;
    [SerializeField] float speed = 10f;
    [SerializeField] Vector2 clamp;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector3 currentPosition = rb.position;
        Vector3 moveDirection = new Vector3(move.x,0,move.y);
        Vector3 newPosition = currentPosition + (moveDirection * speed * Time.fixedDeltaTime);

        newPosition.x = Mathf.Clamp(newPosition.x, -clamp.x,clamp.x);
        newPosition.z = Mathf.Clamp(newPosition.z, -clamp.y,clamp.y);
        rb.MovePosition(newPosition);


    }

    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }  
}
