using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControlScript : MonoBehaviour
{
    public Text HighScoreText;
    public Text PlayButtonText;
    void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("highestScore").ToString();
        PlayButtonText.text = (PlayerPrefs.GetInt("score") == 0) ? "Start Play" : "Continue Play";
    }
    public void StartPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
