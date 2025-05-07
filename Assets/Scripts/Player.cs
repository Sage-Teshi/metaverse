using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // A, D
        float moveY = Input.GetAxis("Vertical");   // W, S

        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed;
        _rigidbody.velocity = movement;
    }
}
