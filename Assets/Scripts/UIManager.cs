using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;
    [SerializeField] TextMeshProUGUI textScore;
    void Start()
    {
        Instance = this;
    }
    public void UpdateScore(int score)
    {
        textScore.text = $"Score: {GameManager.instance.score}";
    }
}
