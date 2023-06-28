using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    [SerializeField] float _punchSpeed = 10;
    [SerializeField] float _punchLife = 2;

    PlayerController _playerController;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerController = FindAnyObjectByType<PlayerController>();
        Destroy(gameObject, _punchLife);
    }

    void Update()
    {
        //ƒvƒŒƒCƒ„[‚ÌŒü‚¢‚Ä‚¢‚é•ûŒü‚É”­Ë
        if (_playerController._frontRight)
        {
            _rb.AddForce(new Vector2(1 * _punchSpeed, transform.position.y), ForceMode2D.Impulse);
        }
        else
        {
            _rb.AddForce(new Vector2(-1 * _punchSpeed, transform.position.y), ForceMode2D.Impulse);
        }
    }
}
