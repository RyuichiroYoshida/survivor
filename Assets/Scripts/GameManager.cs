using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    [SerializeField] Text _coinText;
    [SerializeField] GameObject _gameoverText;

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
    float _coin = 0;

    void Start()
    {
        _gameoverText.SetActive(false);
    }


    void Update()
    {
        _gameTime += Time.deltaTime;

        _coinText.text = _coin.ToString();
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

    public void CoinCount(float coin)
    {
        _coin += coin;
    }

    public void GameOver()
    {
        IsGameOver = true;
        _gameoverText.SetActive(true);
        print("GameOver");
    }
}
