using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool IsGameOver = false;
    bool IsGamePaused = false;
    bool IsGameClear = false;

/*    float _gameMode;
    float _gameModeEasy = 0.5f;
    float _gameModeNomal = 1f;
    float _gameModeHard = 2f;
    float _gameModeVeryHard = 3f;
//“ïˆÕ“x•Ï”‚Â‚­‚è‚©‚¯
    float _gameStage = 1;*/
    float _gameTime = 0;
    float _killCounts = 0;

    void Start()
    {
        
    }


    void Update()
    {
        _gameTime += Time.deltaTime;


    }

/*    void Onclick(int i)
    {
            “ïˆÕ“x‘I‘ğ‚Â‚­‚è‚©‚¯
    }
    public float GameMode()
    {
        return _gameMode;
    }*/

    public void KillCount()
    {
        _killCounts++;
    }

    public void GameOver()
    {
        IsGameOver = true;
        print("GameOver");
    }
}
