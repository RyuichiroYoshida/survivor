using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SaveDate
{
    public float _coinCount;
    public float _killCount;
    public SaveDate(float coin, float kill)
    {
        _coinCount = coin;
        _killCount = kill;
    }
}
