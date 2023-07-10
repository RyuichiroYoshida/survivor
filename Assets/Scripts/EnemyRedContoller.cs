using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedController : EnemyController
{
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _nowHp = _parameters.EnemyRedMaxHP;
    }
    void Update()
    {
        base.Distance(_player, _parameters.EnemyRedMoveSpeed);
        base.KillCount(_nowHp, _parameters.EnemyRedDropCoin);
    }
}
