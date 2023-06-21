using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MyGame / Create ParameterTable")]
public class ParameterTable : ScriptableObject
{
    [SerializeField] float _enemyMaxHP = 1; public float EnemyMaxHP {get {  return _enemyMaxHP; } }
    [SerializeField] float _enemyMoveSpeed = 5; public float EnemyMoveSpeed { get {  return _enemyMoveSpeed; } }

    
}