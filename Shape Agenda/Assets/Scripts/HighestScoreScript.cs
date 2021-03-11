using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScoreScript : MonoBehaviour
{

    public Text highestScoreText;
    void Update()
    {
        highestScoreText.text = PlayerPrefs.GetInt("highestScore").ToString();
    }
}
