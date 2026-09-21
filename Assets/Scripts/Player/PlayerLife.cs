using UnityEngine;
using UnityEngine.UI;

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

    void Start()
    {
        currentLife = maxLife;
        lifeBar.maxValue = maxLife;
        lifeBar.value = currentLife;

        enemyBehaviour = Enemy.GetComponent<EnemyBehaviour>();
        
    }

    public void OnDamage()
    {   
        if (isDamaged == true)
        {
            currentLife -= enemyBehaviour.damage;
            lifeBar.value = currentLife;
            isDamaged = false;
            //essa parte especifica que volta pro false em sequencia do dano é pra evitar q o player morra direto
            // e também pra dar tempo de sair de perto do inimigo, como um momento de invulnerabilidade.
        }
        

        if (currentLife <= 0)
        {
            Destroy(gameObject);
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
    }
}
