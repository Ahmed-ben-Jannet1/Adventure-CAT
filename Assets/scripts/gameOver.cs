
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject backgMusic;
    public GameObject finalPop;
    


    public static gameOver instance;
    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("il ya plus d'instance de GameOver dans la scène");
            return;
        }
        instance = this;
    }

    public void OnPlayerDeath()
    {
        SoundManager.playSound("over");
        if (CurrentSceneManager.instance.isPlayerPresentByDefault)
        {
            dontDestroyOnLoad.instance.RemoveFromDontDestroyOnLoad();
        }
        gameOverUI.SetActive(true);
        backgMusic.SetActive(false);


    }

    public void Retry()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
        herohealth.instance.Respawn();

    }
    
    public void MainMenu()
    {
        invent.instance.del();
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
        gameOverUI.SetActive(false);
    }

    public void Exit()
    { Application.Quit();}

    public void Level2()
    {
        finalPop.SetActive(false);
        invent.instance.del();
        SceneManager.LoadScene("Main"); }

    public void menuee()
    {
      
        SceneManager.LoadScene("menu");
        gameOverUI.SetActive(false);
    }
}
