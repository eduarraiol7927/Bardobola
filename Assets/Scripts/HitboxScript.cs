using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    SpriteRenderer sr;
    //usar pra desvanecer o ataque
    BoxCollider2D bc;
    //caso colida com algo
    Rigidbody2D rb;
    //força pra mover
    


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        
        transform.localScale = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            transform.localScale = new Vector3(0.5f, 0.5f, 0f);
            rb.AddForce(new Vector2(direction * 10f, 0f), ForceMode2D.Impulse);
            // Destroy(Hitbox, 2f);
        }
    }
}

