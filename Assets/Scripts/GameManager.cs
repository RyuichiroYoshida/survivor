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

    bool _isGameOver;
    public bool IsGameOver => _isGameOver;
    bool _isGamePaused;
    bool _isGameClear;

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
    /// <summary>ゲーム経過時間</summary>
    public float GameTimer => _gameTimer;

    void Start()
    {
        JSONLoad();
    }


    void Update()
    {
        GameStart();

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
        _isGameOver = true;
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
        _isGameOver = false;
        _isGamePaused = false;
        _isGameClear = false;

        _gameoverText.SetActive(false);
        _gameoverButton.SetActive(false);
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
