using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static bool isGameOver = false;
    public GameObject gameover;
    public Slider slider;


    void Update()
    {
        if (!isGameOver)
        {
            GameIsOver();
        }
        else
        {
           Restart();
        }
    }

    // Update is called once per frame
    public void LoadSceneAgain()
    {
        SceneManager.LoadScene("gameRide");
    }
    
    public void GameIsOver()
    { 
        if (slider.value == 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            isGameOver = true;
        }
    }

    public void Restart() 
    {
        SceneManager.LoadScene("gameRide");
        isGameOver = false;
        Time.timeScale = 1.0f;
    }
}
