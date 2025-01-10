using UnityEngine.SceneManagement;
using UnityEngine;
using System;



public class Gamemanager : MonoBehaviour
{
    public GameObject LoseWindow;
    public static Gamemanager instance;
    public GameObject PauseWindow;

    private void Start() 
    {
        instance = this;
    }
    
    public void ReatartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        LoseWindow.SetActive(true);
        Time.timeScale = 0;
    }
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }
    public void Pause()
    {
        PauseWindow.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        PauseWindow.SetActive(false);
        Time.timeScale = 1;
    }
}
