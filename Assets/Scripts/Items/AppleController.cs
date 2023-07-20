using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : ItemBase
{
    [SerializeField] float _healValue = 20;

    public override void ItemUse()
    {
        PlayerController player = base._player.GetComponent<PlayerController>();
        player._playerNowHP += _healValue;
        Destroy(gameObject);
    }
}
