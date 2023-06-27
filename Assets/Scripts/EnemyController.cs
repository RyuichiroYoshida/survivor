using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject _player;
    Rigidbody2D _rb;

    float _nowHP;

    [SerializeField] ParameterTable _parameters;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _nowHP = _parameters.EnemyMaxHP;
        _rb = 
    }

    void Update()
    {

        //Enemy Player Distance
        float distance = Vector2.Distance(_player.transform.position, transform.position);
        if (_player != null && distance !> 0.5)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _parameters.EnemyMoveSpeed * Time.deltaTime);
        }

        //Enemy Kill Counts
        if (_nowHP < 0)
        {
            GameManager.instance.KillCount();
            GameManager.instance.CoinCount(_parameters.EnemyDropCoin);
            
            Destroy(gameObject);
        }
    }


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
}
