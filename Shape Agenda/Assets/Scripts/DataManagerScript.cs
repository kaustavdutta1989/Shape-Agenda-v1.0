using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManagerScript : MonoBehaviour
{
    public static void FinishGame()
    {
        HighScoreCheck();
        PlayerPrefs.SetInt("score", 0);
        SceneManager.LoadScene(0);
    }

    public static void ScoreGame()
    {
        int score = PlayerPrefs.GetInt("score") + 10;
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.SetInt("score", score);
    }

    public static float GetEnemySpeed()
    {
        float enemySpeed = 1f;
        if (PlayerPrefs.GetInt("score") >= 50)
        {
            enemySpeed = 1.2f;
            Debug.Log("1.2f");
        }
        if (PlayerPrefs.GetInt("score") >= 150)
        {
            enemySpeed = 1.5f;
            Debug.Log("1.5");
        }
        if (PlayerPrefs.GetInt("score") >= 300)
        {
            enemySpeed = 1.8f;
            Debug.Log("1.8");
        }
        if (PlayerPrefs.GetInt("score") >= 500)
        {
            enemySpeed = 2f;
            Debug.Log("2");
        }
        if (PlayerPrefs.GetInt("score") >= 1000)
        {
            enemySpeed = 2.5f;
            Debug.Log("2.5");
        }
        if (PlayerPrefs.GetInt("score") >= 2000)
        {
            enemySpeed = 3f;
            Debug.Log("3");
        }
        if (PlayerPrefs.GetInt("score") >= 4000)
        {
            enemySpeed = 3.5f;
            Debug.Log("3.5");
        }
        if (PlayerPrefs.GetInt("score") >= 7000)
        {
            enemySpeed = 4f;
            Debug.Log("4");
        }
        if (PlayerPrefs.GetInt("score") >= 10000)
        {
            enemySpeed = 4.5f;
            Debug.Log("4.5");
        }
        if (PlayerPrefs.GetInt("score") >= 1000)
        {
            enemySpeed = 5f;
            Debug.Log("5");
        }
        return enemySpeed;
    }

    private static void HighScoreCheck()
    {
        if (PlayerPrefs.GetInt("highestScore") < PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("highestScore", PlayerPrefs.GetInt("score"));
        }
    }
}
