using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject _player;

    [SerializeField] ParameterTable _parameters;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(_player.transform.position, transform.position);
        if (_player != null && distance !> 0.5)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _parameters.EnemyMoveSpeed * Time.deltaTime);
        }
    }
}
