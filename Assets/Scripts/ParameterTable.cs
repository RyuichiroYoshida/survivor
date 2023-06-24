using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MyGame / Create Enemy ParameterTable")]
public class ParameterTable : ScriptableObject
{
    [SerializeField] float _enemyMaxHP = 1;
        public float EnemyMaxHP {get {  return _enemyMaxHP; } }
    [SerializeField] float _enemyMoveSpeed = 5;
        public float EnemyMoveSpeed { get {  return _enemyMoveSpeed; } }
    [SerializeField] float _enemyAttackDamage = 1;
        public float EnemyAttackDamage { get {  return _enemyAttackDamage; } }
    [SerializeField] float _enemyDropCoin = 1;
        public float EnemyDropCoin { get { return _enemyDropCoin; } }



    [SerializeField] float _playerPunchDamage = 1; public float PlayerPunchDamage { get { return _playerPunchDamage; } }
    [SerializeField] float _playerPunchCoolTime = 3; public float PlayerPunchCoolTime { get { return _playerPunchCoolTime;} }
}