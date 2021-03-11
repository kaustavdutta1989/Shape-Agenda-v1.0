using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.down * DataManagerScript.GetEnemySpeed() * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == gameObject.tag)
        {
            scored(other);
            DataManagerScript.ScoreGame();
        }
        else if(other.CompareTag("Player"))
        {
            DataManagerScript.FinishGame();
        }
    }

    private void scored(Collider2D other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        PlayerPrefs.DeleteKey("spawnShooted");
    }
}
