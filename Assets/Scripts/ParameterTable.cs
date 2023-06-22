using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MyGame / Create Enemy ParameterTable")]
public class ParameterTable : ScriptableObject
{
    [SerializeField] float _enemyMaxHP = 1; public float EnemyMaxHP {get {  return _enemyMaxHP; } }
    [SerializeField] float _enemyMoveSpeed = 5; public float EnemyMoveSpeed { get {  return _enemyMoveSpeed; } }

    [SerializeField] float _enemyAttackDamage = 1; public float EnemyAttackDamage { get {  return _enemyAttackDamage; } }
}