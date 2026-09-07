using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    SpriteRenderer sr;
    //usar pra desvanecer o ataque
    BoxCollider2D bc;
    //caso colida com algo
    Rigidbody2D rb;
    //força pra mover
    private PlayerMovement playerMovement;
    //pra usar uma variavel do script    
    


    void Start()
    //assim q o projetil é instanciado
    {
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        //chamamos nosso script, usando o findwithtag pra puxar-lo do player especificamente.

        transform.localScale = new Vector3(0.5f, 0.5f, 0f);
        //aparece
        rb.AddForce(playerMovement.lastDirection * 5f, ForceMode2D.Impulse);
        //se move, na direção q o player estava ou está andando.
        //coloquei o rb.addforce no start pois no update, um projetil se alterava por conta de outro que acabava de ser atirado.
    }


    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Enemy"))
        {
            //enemyBehaviour.Enemy.life -= damage;
        }
    }
}

