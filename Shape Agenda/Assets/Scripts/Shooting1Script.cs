using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting1Script : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.up * 2f * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            DataManagerScript.FinishGame();
        }
    }
}
