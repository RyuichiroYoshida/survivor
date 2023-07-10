using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemGenerator : MonoBehaviour
{
    public abstract void ItemSpawn();

    /// <summary>Item�𗐐��̍��W�ɐ������郁�\�b�h</summary>
    /// <param name="item">��������Item</param>
    /// <param name="randomX">�����_�����WX</param>
    /// <param name="randomY">�����_�����WY</param>
    void Generate(GameObject item, float randomX, float randomY)
    {
        Instantiate(item, new Vector2(transform.position.x + randomX, transform.position.y + randomY), Quaternion.identity);
    }
    /// <summary>Item��SpwanCoolTime�̃R���[�`�� </summary>
    /// <param name="coolTime">Item��SpawnCoolTime</param>
    IEnumerator SpawnWait(float coolTime)
    {
        yield return new WaitForSeconds(coolTime);
    }
}
