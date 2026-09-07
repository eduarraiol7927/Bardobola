using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    float speed = 7f;
    private Vector2 input;
    public Vector2 lastDirection = Vector2.right;
    //como padrao, se o jogador atirar antes de andar pela primeira vez, a direção sera pra direita.

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        input = value.Get<Vector2>();

        if (input != Vector2.zero)
        {
            lastDirection = input.normalized;
            //a ultima direção do jogador, portanto, quando ele ficasse parado, ficaria registrada, pois o lastDirection nao
            //atualiza pra zero, graças a esse if.
        }
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
