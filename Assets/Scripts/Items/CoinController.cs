using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : ItemBase
{
    [SerializeField] float _coin = 100;
    [SerializeField] float _spawnCoolTime = 3;

    public override void ItemUse()
    {
        //GameManager‚ÌCoinCount‚ÉƒRƒCƒ“‚ð‰ÁŽZ
        GameManager.instance.CoinCount(_coin);
        Destroy(gameObject);
    }
    public override void ItemSpawn()
    {
        StartCoroutine(SpawnWait(_spawnCoolTime, this.gameObject));
    }
}
