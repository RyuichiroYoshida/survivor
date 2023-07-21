using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] int AppleSpawnChanc = 10;
    [SerializeField] GameObject[] _itemPrefabs;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int r = Random.Range(0, 100);
            if (r <= AppleSpawnChanc)
            {
                Instantiate(_itemPrefabs[0], transform.position, Quaternion.identity);
            }
        }
    }
}
