using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool IsGameOver = false;
    bool IsGamePaused = false;
    bool IsGameClear = false;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void GameOver()
    {
        IsGameOver = true;
        print("GameOver");
    }
}
