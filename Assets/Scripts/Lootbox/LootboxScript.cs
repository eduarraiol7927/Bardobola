using UnityEngine;
using EnemyBehaviour;
using PlayerAttack;


public class LootboxScript : MonoBehaviour
//esse script, tal como o script EnemySpawn, fica dentro do Player pro spawn 
// ser relativo a posição do player
{
    public GameObject boxPrefab;
    int count = 0;
    public Vector2 boxPos;

    void Start()
    {

    }

    void EnemyCount()
    {
        if (enemyDead = true) 
        {
            count++;
        }

    }

    void Update()
    {
        if(count % 25)
        //se o numero de inimigos mortos for divisivel por 25, ou seja, multiplo deste
        {   
            Vector2 boxPos = Random.insideUnitCircle * 10f;
            Instantiate(boxPrefab, boxPos, Quaternion.identity);
        }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Lootbox"))
        {
            DropDraw();
        }
    }

    void DropDraw()
    {
        int drawNumber = Random.Range(1, 3);
        Debug.Log(drawNumber);

        if (drawNumber == 1)
        {
            
        }
    }


}












}











