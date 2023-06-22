using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    [SerializeField] float _punchSpeed = 10;

    PlayerController _playerController;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerController = FindAnyObjectByType<PlayerController>();
    }

    void Update()
    {
        if (_playerController._frontRight)
        {
            _rb.AddForce(new Vector2(1 * _punchSpeed, transform.position.y), ForceMode2D.Impulse);
        }
        else
        {
            _rb.AddForce(new Vector2(-1 * _punchSpeed, transform.position.y), ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
        }
    }
}
