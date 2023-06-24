using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text _coinText;

    bool IsGameOver = false;
    bool IsGamePaused = false;
    bool IsGameClear = false;

/*    float _gameMode;
    float _gameModeEasy = 0.5f;
    float _gameModeNomal = 1f;
    float _gameModeHard = 2f;
    float _gameModeVeryHard = 3f;
//難易度変数つくりかけ
    float _gameStage = 1;*/
    float _gameTime = 0;
    float _killCounts = 0;
    float _coin = 0;

    void Start()
    {
        
    }


    void Update()
    {
        _gameTime += Time.deltaTime;


    }

/*    void Onclick(int i)
    {
            難易度選択つくりかけ
    }
    public float GameMode()
    {
        return _gameMode;
    }*/

    public void KillCount()
    {
        _killCounts++;
    }

    public void CoinCount(float coin)
    {
        _coin += coin;
        _coinText.text = _coin.ToString();
    }

    public void GameOver()
    {
        IsGameOver = true;
        print("GameOver");
    }
}
