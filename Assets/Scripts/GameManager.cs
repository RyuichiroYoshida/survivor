using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    [SerializeField] Text _coinText;
    [SerializeField] GameObject _gameoverText;
    [SerializeField] GameObject _gameoverButton;

    bool IsGameOver;
    bool IsGamePaused;
    bool IsGameClear;

/*    float _gameMode;
    float _gameModeEasy = 0.5f;
    float _gameModeNomal = 1f;
    float _gameModeHard = 2f;
    float _gameModeVeryHard = 3f;
//難易度変数つくりかけ
    float _gameStage = 1;*/
    float _gameTime = 0;
    protected float _killCounts = 0;
    protected float _coin = 0;

    float _gameTimer = 0;

    void Start()
    {
        JSONLoad();
    }


    void Update()
    {
        GameStart();
        GameTime();

        _gameTime += Time.deltaTime;

        _coinText.text = _coin.ToString();
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
    }

    public void GameOver()
    {
        IsGameOver = true;
        _gameoverText.SetActive(true);
        _gameoverButton.SetActive(true);
        Time.timeScale = 0;
        print("GameOver");
    }

    public void Title()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("title");
        JSONSave();
    }

    public void GameStart()
    {
        IsGameOver = false;
        IsGamePaused = false;
        IsGameClear = false;

        _gameoverText.SetActive(false);
        _gameoverButton.SetActive(false);
    }
    /// <summary>ゲーム経過時間</summary>
    /// <returns>ゲーム経過時間を返す</returns>
    public float GameTime()
    {
        _gameTime += Time.deltaTime;
        return _gameTime;
    }
    /// <summary>データをJSON形式で保存 </summary>
    public void JSONSave()
    {
        SaveDate saveDate = new SaveDate(_coin, _killCounts);
        string json = JsonUtility.ToJson(saveDate);
        print(json);
        PlayerPrefs.SetString("SaveDate", json);
    }

    public void JSONLoad()
    {
        string json = PlayerPrefs.GetString("SaveDate");
        SaveDate saveDate = JsonUtility.FromJson<SaveDate>(json);
    }
}
