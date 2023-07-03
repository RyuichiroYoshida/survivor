using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MyGame / Create Enemy ParameterTable")]
public class ParameterTable : ScriptableObject
{
    //通常エネミーパラメーター
    [SerializeField] float _enemyMaxHP = 1; public float EnemyMaxHP => _enemyMaxHP;
    [SerializeField] float _enemyMoveSpeed = 5; public float EnemyMoveSpeed => _enemyMoveSpeed;
    [SerializeField] float _enemyAttackDamage = 1; public float EnemyAttackDamage => _enemyAttackDamage;
    [SerializeField] float _enemyDropCoin = 1; public float EnemyDropCoin => _enemyDropCoin;
    //強化エネミーパラメーター
    [SerializeField] float _enemyRedMaxHP = 1; public float EnemyRedMaxHP => _enemyRedMaxHP;
    [SerializeField] float _enemyRedMoveSpeed = 5; public float EnemyRedMoveSpeed => _enemyRedMoveSpeed;
    [SerializeField] float _enemyRedAttackDamage = 1; public float EnemyRedAttackDamage => _enemyRedAttackDamage;
    [SerializeField] float _enemyRedDropCoin = 1; public float EnemyRedDropCoin => _enemyRedDropCoin;
    //プレイヤー武器パラメーター
    [SerializeField] float _playerPunchDamage = 1; public float PlayerPunchDamage => _playerPunchDamage;
    [SerializeField] float _playerPunchCoolTime = 3; public float PlayerPunchCoolTime => _playerPunchCoolTime;
    [SerializeField] float _plyaerNumberOfPunches = 1; public float PlayerNumberOfPunches => _plyaerNumberOfPunches;
    [SerializeField] float _playerBatDamage = 1; public float PlyerBatDamage => _playerBatDamage;
    [SerializeField] float _playerBatSize = 1; public float BatSize => _playerBatSize;
}