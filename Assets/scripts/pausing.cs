using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausing : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject musica;
    public GameObject soundMenu;

    
    void Start()
    {
        musica = GameObject.FindGameObjectWithTag("backg");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        musica.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        

    }
    public void Pause()
    {

        pauseMenu.SetActive(true);
        musica.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;       
    }

    public void soundPause()
    {
        soundMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void backing()
    {
        soundMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
