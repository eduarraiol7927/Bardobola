using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public float damage = 5f;
    public GameObject Player;
    private PlayerLife playerLife;
    float life = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerLife = Player.GetComponent<PlayerLife>();
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Projectile"))
        {
            life -= 5f;
            Debug.Log(life);
        }
    }

    void ChasePlayer()
    {
        transform.position = new Vector2(Mathf.MoveTowards(transform.position.x, Player.transform.position.x, 2f * Time.deltaTime),
                                         Mathf.MoveTowards(transform.position.y, Player.transform.position.y, 2f * Time.deltaTime));
    }

    void Update()
    {
       ChasePlayer();

       if (life <= 0)
       {
        Destroy(gameObject);
       }
    }

}
