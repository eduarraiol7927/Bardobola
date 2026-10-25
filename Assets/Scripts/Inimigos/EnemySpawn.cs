using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
//esse script fica dentro do Player pro spawn ser relativo a posição do player
{
    public GameObject enemyPrefab;
    //ao arrastar o prefab, é importante que voce arraste o prefab dos assets, nao da hierarchy, pq se for da hierarchy,
    //quando o inimigo morre, o prefab também morre
    public Transform spawnPosition;   

    void Start()
    {
        StartCoroutine(SpawnEnemy());
        
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Vector2 spawnPosition = Random.insideUnitCircle * 10f;
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        }
    }

    
    void Update()
    {
        
    }
}
