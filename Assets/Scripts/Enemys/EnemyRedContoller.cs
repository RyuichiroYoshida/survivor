using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedController : EnemyController
{
    void Start()
    {
        //Player‚ÌGameObject‚ğæ“¾
        _player = GameObject.FindGameObjectWithTag("Player");
        //Œ»İHp(float)‚Éƒpƒ‰ƒ[ƒ^‚©‚çÅ‘åHp‚ğ‘ã“ü
        _nowHp = _parameters.EnemyRedMaxHP;
    }
    void Update()
    {
        base.Distance(_player, _parameters.EnemyRedMoveSpeed);
        base.KillCount(_nowHp, _parameters.EnemyRedDropCoin);
    }
}
