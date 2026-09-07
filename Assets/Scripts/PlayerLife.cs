using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    float damage;
    //só pra testar
    public float maxLife = 100f;
    public float currentLife;
    bool isDamaged;

    public Slider lifeBar;

    void Start()
    {
        currentLife = maxLife;
        lifeBar.maxValue = maxLife;
        lifeBar.value = currentLife;
        
    }

    public void OnDamage()
    {   
        if (isDamaged == true)
        {
            currentLife -= damage;
            lifeBar.value = currentLife;
            isDamaged = false;
            //essa volta pro false em sequencia é pra evitar q o player morra direto e também pra dar tempo de sair de perto
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
