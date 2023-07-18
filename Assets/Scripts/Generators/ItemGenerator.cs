using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] float _coinSpawnCoolTime = 5;
    [SerializeField] GameObject _coinPrefab;


    private void Start()
    {
        print("itemStart");
        StartCoroutine(SpawnCoin());
    }

    private void Update()
    {
        
    }

    IEnumerator SpawnCoin()
    {
        yield return new WaitForSeconds(_coinSpawnCoolTime);
        float x = Random.Range(-10, 10);
        float y = Random.Range(-10, 10);
        Instantiate(_coinPrefab, new Vector2(transform.position.x + x, transform.position.y + y), Quaternion.identity);
        StartCoroutine(SpawnCoin());
    }
}
