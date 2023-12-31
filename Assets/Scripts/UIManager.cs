using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;
    [SerializeField] TextMeshProUGUI textScore;

    [Header("StartButton")]
    public Button tapToPlay;
    
    [Header("PAUSE")]
    [SerializeField] Button pauseButton;
    [SerializeField] Image pauseBtnIMG;
    [SerializeField] Sprite pauseButtonIMG;
    [SerializeField] Sprite resumeButtonIMG;

    [SerializeField] GameObject pausedPanel;
    [SerializeField] Button resumeButt;
    [SerializeField] Button goMainButt;

    [Header("LOSE")]
    [SerializeField] GameObject loseUI;
    
    [SerializeField] Image medal;
    [SerializeField] Sprite medalCu;
    [SerializeField] Sprite medalAg;
    [SerializeField] Sprite medalAu;

    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI hightScore;


    void Start()
    {
        Instance = this;
        loseUI.SetActive(false);
        pauseBtnIMG.sprite = pauseButtonIMG;
        pauseButton.onClick.AddListener(GameManager.instance.ClickPauseButt);
        tapToPlay.onClick.AddListener(GameManager.instance.OnGameReadyClick);
        resumeButt.onClick.AddListener(GameManager.instance.ClickPauseButt);
        goMainButt.onClick.AddListener(GameManager.instance.goMain);
    }
    public void UpdateScore(int score)
    {
        textScore.text = $"{GameManager.instance.score}";
    }
    public void OnPauseButtClick()
    {
        if (GameManager.instance.isGamePause)
        {
            pauseBtnIMG.sprite = resumeButtonIMG;
            pausedPanel.SetActive(true);
        }
        else
        {
            pauseBtnIMG.sprite = pauseButtonIMG;
            pausedPanel.SetActive(false);
        }

    }
    public void OpenLoseUI()
    {
        UpdateLosePanel();
        loseUI.SetActive(true);
    }
    public void UpdateLosePanel()
    {
        //medal
        if (GameManager.instance.medal == "Cu") medal.sprite = medalCu;
        if (GameManager.instance.medal == "Ag") medal.sprite = medalAg;
        if (GameManager.instance.medal == "Au") medal.sprite = medalAu;
        //score
        score.text = GameManager.instance.score.ToString();
        hightScore.text = GameManager.instance.highScore.ToString();
    }

    
}
