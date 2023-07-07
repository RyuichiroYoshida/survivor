using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedController : EnemyController
{
    GameObject _player;
    Rigidbody2D _rb;

    float _nowHP;

    [SerializeField] ParameterTable _parameters;

    void Start()
    {
        //EnemyRedController enemyRedController = new EnemyRedController();

        _player = GameObject.FindGameObjectWithTag("Player");
        _nowHP = _parameters.EnemyRedMaxHP;
    }

    void Update()
    {
        base.Distance(_player);
        //Enemy Kill Counts
        if (_nowHP <= 0)
        {
            GameManager.instance.KillCount();
            GameManager.instance.CoinCount(_parameters.EnemyRedDropCoin);
            Destroy(gameObject);
        }
    }

    /*
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "punch")
            {
                print("PunchHit");
                _nowHP -= _parameters.PlayerPunchDamage;
            }
            if (collision.gameObject.tag == "Player")
            {
                print("playerHit");
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if ((collision.gameObject.tag == "bat"))
            {
                print("BatHit");
                _nowHP -= _parameters.PlyerBatDamage;
            }
        }*/
}
