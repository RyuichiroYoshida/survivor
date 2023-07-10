using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemGenerator : MonoBehaviour
{
    public abstract void ItemSpawn();

    /// <summary>Itemを乱数の座標に生成するメソッド</summary>
    /// <param name="item">生成するItem</param>
    /// <param name="randomX">ランダム座標X</param>
    /// <param name="randomY">ランダム座標Y</param>
    void Generate(GameObject item, float randomX, float randomY)
    {
        Instantiate(item, new Vector2(transform.position.x + randomX, transform.position.y + randomY), Quaternion.identity);
    }
    /// <summary>ItemのSpwanCoolTimeのコルーチン </summary>
    /// <param name="coolTime">ItemのSpawnCoolTime</param>
    IEnumerator SpawnWait(float coolTime)
    {
        yield return new WaitForSeconds(coolTime);
    }
}
