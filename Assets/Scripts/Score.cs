using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float score;

    [SerializeField] TextMeshProUGUI scoreUI;

    private void Update()
    {
        ScoreUI();
    }
    private void ScoreUI()
    {
        scoreUI.text = $"Score: {score}";
    }
}
