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
//��Փx�ϐ����肩��
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
            ��Փx�I�����肩��
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
