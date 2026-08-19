using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 7f;
    public Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove( InputValue inputValue)
    {
        input = inputValue.Get<Vector2>();

    }

    void Update()
    {
        rb.linearVelocity = speed * input;
    }

}
