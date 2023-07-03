using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreUI;

    private void Update()
    {
        Score_UI();
    }
    private void Score_UI()
    {
        scoreUI.text = $"{GameManager.instance.score}";
    }
}
