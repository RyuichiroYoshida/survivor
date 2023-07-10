using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedController : EnemyController
{
    void Start()
    {
        //Player��GameObject���擾
        _player = GameObject.FindGameObjectWithTag("Player");
        //����Hp(float)�Ƀp�����[�^����ő�Hp����
        _nowHp = _parameters.EnemyRedMaxHP;
    }
    void Update()
    {
        base.Distance(_player, _parameters.EnemyRedMoveSpeed);
        base.KillCount(_nowHp, _parameters.EnemyRedDropCoin);
    }
}
