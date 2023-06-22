using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject _player;

    float _nowHP;

    [SerializeField] ParameterTable _enemyParameters;
    [SerializeField] ParameterTable _playerParameters;
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
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _enemyParameters.EnemyMoveSpeed * Time.deltaTime);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Punch")
        {
            print("Punch Hit");
        }
    }
}
