using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _jumpForce = 12f;

    [SerializeField] private PlayerDeathHandler deathHandler;

    private Rigidbody2D _rb;
    private bool _isGrounded;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();    
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.right * _speed;
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (_isGrounded)
        {
            _rb.velocity = Vector2.up * _jumpForce;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
            _isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
            _isGrounded = false;
    }
}
