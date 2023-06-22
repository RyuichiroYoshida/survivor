using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _playerHP = 20;
    [SerializeField] float _playerMoveSpeed = 5;
    [SerializeField] float _punchCoolTime = 3;

    [System.NonSerialized] public bool _frontRight = true;

    Rigidbody2D _rb;
    SpriteRenderer _sprite;

    [SerializeField] GameObject _punchPrefab;

    [SerializeField] ParameterTable _enemyParameters;
    [SerializeField] ParameterTable _playerParameters;
    [SerializeField] GameManager _gameManager;

    float _punchTimer = 0;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();   
        _sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _punchTimer += Time.deltaTime;

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(moveX, moveY).normalized;
        _rb.velocity = direction * _playerMoveSpeed;

        FlipX(moveX);

        if (Input.GetButton("Fire1"))
        {
            if (_punchTimer > _punchCoolTime)
            {
                Attack(_frontRight);
                _punchTimer = 0;
            }
        }

        if (_playerHP < 0)
        {
            _gameManager.GameOver();
        }

    }

    void FlipX(float horizontal)
    {
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
            _sprite.flipX = true;
            _frontRight = true;
        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1 * Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
            _sprite.flipX = false;
            _frontRight = false;
        }
    }

    public void Attack(bool right)
    {
        if (right)
        {
            Instantiate(_punchPrefab, new Vector2(transform.position.x + 1, transform.position.y), Quaternion.identity);
        }
        else
        {
            Instantiate(_punchPrefab, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _playerHP -= _enemyParameters.EnemyAttackDamage;
            print(_playerHP);
        }
    }
}
