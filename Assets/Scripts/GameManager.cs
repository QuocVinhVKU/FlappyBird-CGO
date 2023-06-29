using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameOver = false;
    public int score;

    void Start()
    {
        instance = this;
    }

    public void GameOver()
    {
        isGameOver = true;
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        UIManager.Instance.UpdateScore(score);
        AudioManager.Instance.CollectCoinAudio();
    }
}
