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

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            playerLife.maxLife -= damage;
        }
    }

    void Update()
    {
       
    }
}
