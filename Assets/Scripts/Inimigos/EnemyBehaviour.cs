using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{   
    private Rigidbody2D rb;
    public float enemyDamage = 5f;
    public GameObject Player;
    private PlayerLife playerLife;
    public float life = 20f;
    public bool isDead = false;
    public LootboxScript lootscript;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        lootscript = Player.GetComponent<LootboxScript>();

        rb = GetComponent<Rigidbody2D>();
        playerLife = Player.GetComponent<PlayerLife>();
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Projectile"))
        {
            life -= playerLife.playerDamage;
            Debug.Log("Vida inimigo: " + life);
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
            lootscript.count++;
            Destroy(gameObject);
        }
        
    }

}