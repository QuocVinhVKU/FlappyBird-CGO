using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuUI : MonoBehaviour
{
    public static MainMenuUI instance;
    public Button yellowBirdButt;
    public Button blueBirdButt;
    [SerializeField] Button okButt;
    public TextMeshProUGUI mess;

    private void Start()
    {
        instance = this;
        yellowBirdButt.onClick.AddListener(MainMenuManager.instance.OnYellowBirdClick);
        blueBirdButt.onClick.AddListener(MainMenuManager.instance.OnBlueBirdClick);
        okButt.onClick.AddListener(MainMenuManager.instance.OnOKButtClick);
    }

}
