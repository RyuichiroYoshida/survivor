using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] float _enemySpawnCoolTime = 2;
    [SerializeField] float _enemyRedSpawnCoolTime = 7;
    [SerializeField] float _startRedEnemySpawnTime = 10;

    [SerializeField] GameObject[] _enemyPrefabs;

    float timer = 0;
    float timer2 = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer > _enemySpawnCoolTime)
        {
            float randomX = Random.Range(-5, 5);
            float randomY = Random.Range(-5, 5);
            Instantiate(_enemyPrefabs[0], new Vector2(transform.position.x + randomX, transform.position.y + randomY), Quaternion.identity);
            timer = 0;
        }
        if (timer2 > _enemyRedSpawnCoolTime && GameManager.instance.GameTime() > _startRedEnemySpawnTime)
        {
            float randomX = Random.Range(-5, 5);
            float randomY = Random.Range(-5, 5);
            Instantiate(_enemyPrefabs[1], new Vector2(transform.position.x + randomX, transform.position.y + randomY), Quaternion.identity);
            timer2 = 0;
        }
    }
}
