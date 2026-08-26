using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    float speed = 7f;
    private Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        input = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        if (input != Vector2.zero){
            rb.linearVelocity = input * speed;
        }
        else
        {
            rb.linearVelocity = new Vector2(Mathf.MoveTowards(rb.linearVelocity.x, 0f, 25f * Time.deltaTime), 
            Mathf.MoveTowards(rb.linearVelocity.y, 0f, 25f * Time.deltaTime));
        }
    }

}
