using UnityEngine;
using UnityEngine.UI;
//para configurarmos a barra de vida
using UnityEngine.SceneManagement;
//para configurarmos a cena que vai ser recarregada quando o player morrer

public class PlayerLife : MonoBehaviour
{
    float damage;
    //só pra testar, mas esse damage sera atribuido pelo enemybehaviour.cs
    public float maxLife = 100f;
    public float currentLife;
    bool isDamaged;
    public GameObject Enemy;
    EnemyBehaviour enemyBehaviour;

    public Slider lifeBar;  
    private Rigidbody2D rb;

    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        rb = GetComponent<Rigidbody2D>();
        currentLife = maxLife;
        lifeBar.maxValue = maxLife;
        lifeBar.value = currentLife;

        enemyBehaviour = Enemy.GetComponent<EnemyBehaviour>();
        
    }

    public void OnDamage()
    {   
        if (isDamaged == true)
        {
            Vector2 direction = (transform.position - Enemy.transform.position).normalized;

            currentLife -= enemyBehaviour.damage;
            lifeBar.value = currentLife;
            rb.AddForce(direction * 15f, ForceMode2D.Impulse);
            //knockback que o inimigo da no player
            isDamaged = false;
        }
        

        if (currentLife <= 0)
        {
            Destroy(gameObject);
            //cabe colocar uma tela de menu aqui, que voce retornaria, mas por enquanto, apenas recarrega a cena.
            SceneManager.LoadScene("Gameplay");
        }
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("levou dano");
            isDamaged = true;
        }
        else
        {
            isDamaged = false;
        }
    }

    void Update()
    {
        OnDamage();

        if (Enemy == null)
        {
            Enemy = GameObject.FindGameObjectWithTag("Enemy");
        //isso aqui foi colocado pra resolver o problema de quando o inimigo morre, porque o prefab dele vira null e o player
        //nao toma mais dano. aí com isso ele encontra o inimigo que é instanciado a cada 5 segundos.
        }
    }
}
