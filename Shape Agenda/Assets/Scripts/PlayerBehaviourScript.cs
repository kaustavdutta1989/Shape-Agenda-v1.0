using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehaviourScript : MonoBehaviour
{
    public GameObject[] shooterList;
    public Text playerScore;

    float timeBtwnSpawn;

    void Awake()
    {
        Debug.Log("Continued Score : " + PlayerPrefs.GetInt("score"));
        PlayerPrefs.SetInt("gameOver", 0);
        PlayerPrefs.SetInt("spawnShooted", 0);
    }

    void Update()
    {
        LoadScore();

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Ended)
            {
                move(Camera.main.ScreenToWorldPoint(touch.position));
            }
        }
        if(timeBtwnSpawn > 0)
        {
            timeBtwnSpawn -= Time.deltaTime;
        }        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void move(Vector2 position)
    {
        if (position.y > 4f && position.x > 2)
        {
            gotoMainMenu();
        }
        else if (position.y > -3.75f && position.y < 4f)
        {
            if (position.x > 1)
            {
                transform.position = new Vector2(2, -3);
            }
            else if (position.x < -1)
            {
                transform.position = new Vector2(-2, -3);
            }
            else if (position.x > -1 && position.x < 1)
            {
                transform.position = new Vector2(0, -3);
            }
        }
        else
        {
            if(PlayerPrefs.GetInt("spawnShooted") == 0)
            {
                if (position.x > -0.5 && position.x < 0.5)
                {
                    Instantiate(shooterList[0], new Vector3(transform.position.x, -1.5f, 0), Quaternion.identity);
                }
                else if (position.x > 0.5 && position.x < 1.5)
                {
                    Instantiate(shooterList[1], new Vector3(transform.position.x, -1.5f, 0), Quaternion.identity);
                }
                else if (position.x < -0.5 && position.x > -1.5)
                {
                    Instantiate(shooterList[2], new Vector3(transform.position.x, -1.5f, 0), Quaternion.identity);
                }
                else if (position.x < -1.5 && position.x > -2.5)
                {
                    Instantiate(shooterList[3], new Vector3(transform.position.x, -1.5f, 0), Quaternion.identity);
                }
                else if (position.x > 1.5 && position.x < 2.5)
                {
                    Instantiate(shooterList[4], new Vector3(transform.position.x, -1.5f, 0), Quaternion.identity);
                }
                
                PlayerPrefs.SetInt("spawnShooted", 1);
                timeBtwnSpawn = Random.Range(1.5f, 2.5f); ;
            }
        }
    }

    private void LoadScore()
    {
        playerScore.text = PlayerPrefs.GetInt("score").ToString();
    }

    public void gotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
