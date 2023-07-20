using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _playerHP = 20;
    [SerializeField] float _playerMoveSpeed = 5;
    [System.NonSerialized] public float _playerNowHP = 0;

    [System.NonSerialized] public bool _frontRight = true;

    Rigidbody2D _rb;
    SpriteRenderer _sprite;
    GameObject _gameManager;

    [SerializeField] GameObject _punchPrefab;
    [SerializeField] Slider _HPbar;

    [SerializeField] ParameterTable _parameters;

    float _punchTimer = 0;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();   
        _sprite = gameObject.GetComponent<SpriteRenderer>();
        _gameManager = transform.Find(nameof(GameManager)).gameObject;

        _HPbar.value = 1;
        _playerNowHP = _playerHP;
    }

    void Update()
    {
        _punchTimer += Time.deltaTime;

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(moveX, moveY).normalized;
        _rb.velocity = direction * _playerMoveSpeed;


        FlipX(moveX);

        _HPbar.value = _playerNowHP / _playerHP;

        if (Input.GetButton("Fire1"))
        {
            if (_punchTimer > _parameters.PlayerPunchCoolTime)
            {
                Attack(_frontRight);
                _punchTimer = 0;
            }
        }

        if (_playerNowHP < 0)
        {
            _gameManager.transform.parent = null;
            gameObject.transform.DetachChildren();
            GameManager.instance.GameOver();
            Destroy(gameObject);
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
            if (_parameters.PlayerNumberOfPunches >= 3)
            {
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x + 0.5f, transform.localPosition.y + 1f), Quaternion.identity);
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x + 0.5f, transform.localPosition.y), Quaternion.identity);
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x + 0.5f, transform.localPosition.y - 1f), Quaternion.identity);
            }
            else if (_parameters.PlayerNumberOfPunches >= 2)
            {
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x + 0.5f, transform.localPosition.y + 0.5f), Quaternion.identity);
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x + 0.5f, transform.localPosition.y - 0.5f), Quaternion.identity);
            }
            else
            {
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x + 0.5f, transform.localPosition.y), Quaternion.identity);
            }
        }
        else
        {
            if (_parameters.PlayerNumberOfPunches >= 3)
            {
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x - 0.5f, transform.localPosition.y + 1f), Quaternion.identity);
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x - 0.5f, transform.localPosition.y), Quaternion.identity);
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x - 0.5f, transform.localPosition.y - 1f), Quaternion.identity);
            }
            else if (_parameters.PlayerNumberOfPunches >= 2)
            {
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x - 0.5f, transform.localPosition.y + 0.5f), Quaternion.identity);
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x - 0.5f, transform.localPosition.y - 0.5f), Quaternion.identity);
            }
            else
            {
                Instantiate(_punchPrefab, new Vector2(transform.localPosition.x - 0.5f, transform.localPosition.y), Quaternion.identity);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _playerNowHP -= _parameters.EnemyAttackDamage;
            print(_playerNowHP);
        }
    }
}
