using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] float _enemySpawnCoolTime = 2;

    [SerializeField] GameObject _enemyPrefab;

    float timer = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > _enemySpawnCoolTime)
        {
            float randomX = Random.Range(-5, 5);
            float randomY = Random.Range(-5, 5);
            Instantiate(_enemyPrefab, new Vector2(transform.position.x + randomX, transform.position.y + randomY), Quaternion.identity);
            timer = 0;
        }
    }
}
