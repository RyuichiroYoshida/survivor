using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedController : EnemyController
{
    void Start()
    {
        //PlayerのGameObjectを取得
        _player = GameObject.FindGameObjectWithTag("Player");
        //現在Hp(float)にパラメータから最大Hpを代入
        _nowHp = _parameters.EnemyRedMaxHP;
    }
    void Update()
    {
        base.Distance(_player, _parameters.EnemyRedMoveSpeed);
        base.KillCount(_nowHp, _parameters.EnemyRedDropCoin);
    }
}
