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
        //Player��GameObject���擾
        _player = GameObject.FindGameObjectWithTag("Player");
        //����Hp(float)�Ƀp�����[�^����ő�Hp����
        _nowHp = _parameters.EnemyMaxHP;
    }

    void Update()
    {
        Distance(_player, _parameters.EnemyMoveSpeed);
        KillCount(_nowHp, _parameters.EnemyDropCoin);
    }
    /// <summary>Enemy �� Player �� Distance���擾���āAEnemy��ˌ�������</summary>
    /// <param name="player">Start�Ŏ擾�����v���C���[�̃Q�[���I�u�W�F�N�g</param>
    protected void Distance(GameObject player, float speed)
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if (player != null && distance! > 0.5)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
    /// <summary>Enemy�̌���HP���Q�Ƃ��āA0�Ȃ�KillCount��CoinCount�����Z����</summary>
    /// <param name="nowHp">Enemy�̌���Hp</param>
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
