using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    public GameObject[] enemyList;
    float startTimeBtwnSpawn;

    float timeBtwnSpawn;

    void Update()
    {
        startTimeBtwnSpawn = Random.Range(1.5f, 3f);
        spawnEnemy();
    }

    private void spawnEnemy()
    {
        if (timeBtwnSpawn <= 0 && PlayerPrefs.GetInt("spawnShooted") == 0)
        {
            int randPosition = Random.Range(-1, 2);
            randPosition *= 2;

            Instantiate(
                enemyList[Random.Range(0, enemyList.Length)],
                new Vector3(randPosition, 3.5f, 0),
                Quaternion.identity
                );

            timeBtwnSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeBtwnSpawn -= Time.deltaTime;
        }
    }

}
