using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MyGame / Create Enemy ParameterTable")]
public class ParameterTable : ScriptableObject
{
    [SerializeField] float _enemyMaxHP = 1;
    public float EnemyMaxHP => _enemyMaxHP;
    [SerializeField] float _enemyMoveSpeed = 5;
    public float EnemyMoveSpeed => _enemyMoveSpeed;
    [SerializeField] float _enemyAttackDamage = 1;
    public float EnemyAttackDamage => _enemyAttackDamage;
    [SerializeField] float _enemyDropCoin = 1;
    public float EnemyDropCoin => _enemyDropCoin;



    [SerializeField] float _playerPunchDamage = 1; public float PlayerPunchDamage => _playerPunchDamage;
    [SerializeField] float _playerPunchCoolTime = 3; public float PlayerPunchCoolTime => _playerPunchCoolTime;
    [SerializeField] float _plyaerNumberOfPunches = 1; public float PlayerNumberOfPunches => _plyaerNumberOfPunches;
}