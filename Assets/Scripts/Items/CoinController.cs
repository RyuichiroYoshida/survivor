using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : ItemBase
{
    [SerializeField] float _coin = 100;

    public override void ItemUse()
    {
        //GameManager��CoinCount�ɃR�C�������Z
        GameManager.instance.CoinCount(_coin);
        Destroy(gameObject);
    }
}
