using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public BirdController bird;

    public bool isGameOver = false;
    public bool isGamePause = false;
    public bool isGameReady = false;

    public int score;
    public int highScore;

    public string medal;
    //===========LOGIC==========
    void Awake()
    {
        instance = this;
        LoadHighScore();
    }
    public void OnGameReadyClick()
    {
        isGameReady = true;
        bird.CheckGameReady();
        UIManager.Instance.tapToPlay.gameObject.SetActive(false);
    }
    public void GameOver()
    {
        isGameOver = true;
        ScoreEndGame();
        CheckMedal();
        UIManager.Instance.OpenLoseUI();
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        UIManager.Instance.UpdateScore(score);
        AudioManager.Instance.CollectCoinAudio();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //============PAUSE GAME============
    public void ClickPauseButt()
    {
        if (isGamePause)
        {
            Resume();
        }
        else GamePause();
        UIManager.Instance.OnPauseButtClick();
    }
    protected void GamePause()
    {
        isGamePause = true;
        Time.timeScale = 0f;
    }
    protected void Resume()
    {
        isGamePause = false;
        Time.timeScale = 1f;
    }
    //============SCORE=============
    void LoadHighScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
    }
    void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save(); 
    }
    void ScoreEndGame()
    {
        if (score > highScore)
        {
            highScore = score;
            SaveHighScore(); 
        }
    }
    void CheckMedal()
    {
        if (score < 3)
        {
            medal = "Cu";
        }
        else if (score < 6)
        {
            medal = "Ag";
        }
        else medal = "Au";
    }
}
