using UnityEngine;


public class LootboxScript : MonoBehaviour
//esse script, tal como o script EnemySpawn, fica dentro do Player pro spawn 
// ser relativo a posição do player
{   
    EnemyBehaviour enemBeh;
    PlayerLife playerLife;
    public GameObject boxPrefab;
    public int count = 0;
    public int meta = 25;
    public Vector2 boxPos;

    void Start()
    {
        boxPrefab.SetActive(false);
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        GameObject Enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemBeh = Enemy.GetComponent<EnemyBehaviour>();
        playerLife = Player.GetComponent<PlayerLife>();
    }

    void Update()
    {

        Debug.Log("Inimigos mortos: " + count);
        if (count >= meta)
        //se o numero de inimigos mortos for maior ou igual a meta de inimigos(25, 50, 100, 200...), spawnar uma lootbox
        {   
            Vector2 boxPos = Random.insideUnitCircle * 10f;
            Instantiate(boxPrefab, boxPos, Quaternion.identity);
            boxPrefab.SetActive(true);
            meta *= 2;
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Lootbox"))
        {
            DropDraw();
            boxPrefab.SetActive(false);
        }
    }

    void DropDraw()
    {
        int drawNumber = Random.Range(1, 3);
        Debug.Log(drawNumber);

        if (drawNumber == 1)
        {
            playerLife.maxLife +=20f;
        }
        
        if (drawNumber == 2)
        {
            playerLife.playerDamage += 5f;
        }
    }
}












