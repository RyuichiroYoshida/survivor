using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : ItemBase
{
    [SerializeField] float _coin = 100;

    public override void ItemUse()
    {
        //GameManagerのCoinCountにコインを加算
        GameManager.instance.CoinCount(_coin);
        Destroy(gameObject);
    }
}
