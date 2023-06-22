using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyGame / Create Player ParameterTable")]
public class PlayerParameterTable : ScriptableObject
{
    [SerializeField] float _punchDamage = 1; public float PunchDamage { get { return _punchDamage; } }
}
