using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    GameObject _player;
    public abstract void ItemUse();

    public abstract void ItemSpawn();

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        ItemSpawn();
    }

    /// <summary>Itemを乱数の座標に生成するメソッド</summary>
    /// <param name="item">生成するItem</param>
    protected void Generate(GameObject item)
    {
        float randomX = Random.Range(-10, 10);
        float randomY = Random.Range(-10, 10);
        Instantiate(item, new Vector2(_player.transform.position.x + randomX, _player.transform.position.y + randomY), Quaternion.identity);
    }
    /// <summary>ItemのSpwanCoolTimeのコルーチン </summary>
    /// <param name="coolTime">ItemのSpawnCoolTime</param>
    protected IEnumerator SpawnWait(float coolTime, GameObject item)
    {
        yield return new WaitForSeconds(coolTime);
        Generate(item);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ItemUse();
        }
    }
}
