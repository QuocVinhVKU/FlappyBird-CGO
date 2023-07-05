using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager instance;
    private string bird;
    void Awake()
    {
        instance = this;

    }
    private void Start()
    {
        PlayerPrefs.DeleteKey("Bird");  
        LoadBirdUI();
        
    }
    public void LoadBirdUI()
    {
        if (PlayerPrefs.HasKey("Bird"))
        {
            bird = PlayerPrefs.GetString("Bird");
            if (bird == "yellow")
            {
                ChangeBirdColor("yellow");
            }
            if(bird == "blue")
            {
                ChangeBirdColor("blue");
            }
        }
    }
    private void ChangeBirdColor(string bird)
    {
        if (bird == "yellow") 
        { 
            MainMenuUI.instance.yellowBirdButt.image.color = new Color(0.5f, 0.5f, 1f);
            MainMenuUI.instance.blueBirdButt.image.color = new Color(1f, 1f, 1f);
        }
        if (bird == "blue")
        {
            MainMenuUI.instance.blueBirdButt.image.color = new Color(0.5f, 0.5f, 1f);
            MainMenuUI.instance.yellowBirdButt.image.color = new Color(1f, 1f, 1f);
        }
    }
    public void OnYellowBirdClick()
    {
        PlayerPrefs.SetString("Bird", "yellow");
        ChangeBirdColor("yellow");
    }
    public void OnBlueBirdClick()
    {
        PlayerPrefs.SetString("Bird", "blue");
        ChangeBirdColor("blue");
    }
    public void OnOKButtClick()
    {
        if (!PlayerPrefs.HasKey("Bird"))
        {
            Mess("Please Select a bird before Play");
        }
        else
        {
            SceneManager.LoadScene("GamePlay");
        }
    }
    public void Mess(string mess)
    {
        MainMenuUI.instance.mess.text = mess;
    }
}
