using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public float damage = 5f;
    private GameObject Player;
    private PlayerLife playerLife;
    float life = 20f;
    bool enemyDead;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody2D>();
        playerLife = Player.GetComponent<PlayerLife>();
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Projectile"))
        {
            life -= damage;
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
        enemyDead = true;
        Destroy(gameObject);
       }
       else
       {
        enemyDead = false;
       }
    }

}
