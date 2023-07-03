using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Sword : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOLocalRotate(new Vector3(0, 0, 90), 5, mode: RotateMode.WorldAxisAdd);
        transform.DOLocalMove(new Vector3(0, -5, 0), 5)
                 .SetLoops(1, LoopType.Yoyo);
    }
}
