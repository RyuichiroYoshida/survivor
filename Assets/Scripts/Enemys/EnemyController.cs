using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    protected GameObject _player;

    protected float _nowHp;

    public ParameterTable _parameters;

    void Start()
    {
        //PlayerのGameObjectを取得
        _player = GameObject.FindGameObjectWithTag("Player");
        //現在Hp(float)にパラメータから最大Hpを代入
        _nowHp = _parameters.EnemyMaxHP;
    }

    void Update()
    {
        Distance(_player, _parameters.EnemyMoveSpeed);
        KillCount(_nowHp, _parameters.EnemyDropCoin);
    }
    /// <summary>Enemy と Player の Distanceを取得して、Enemyを突撃させる</summary>
    /// <param name="player">Startで取得したプレイヤーのゲームオブジェクト</param>
    protected void Distance(GameObject player, float speed)
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if (player != null && distance! > 0.5)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
    /// <summary>Enemyの現在HPを参照して、0ならKillCountとCoinCountを加算する</summary>
    /// <param name="nowHp">Enemyの現在Hp</param>
    protected void KillCount(float nowHp, float dropCoin)
    {
        if (nowHp <= 0)
        {
            GameManager.instance.KillCount();
            GameManager.instance.CoinCount(dropCoin);
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
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
            _nowHp -= _parameters.PlyerBatDamage;
        }
        if (collision.gameObject.tag == "punch")
        {
            print("PunchHit");
            _nowHp -= _parameters.PlayerPunchDamage;
        }
    }
}
