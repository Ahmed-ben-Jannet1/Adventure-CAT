using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class invent : MonoBehaviour
{
    public int coinsCount;
    public int deathCount;
    private float score;
    public GameObject fpop;
    public GameObject backgMusic;

    public Text CoinsCountText;
    public Text scoreText;
    public Text highScoreText;

    public static invent instance;

    private void OnEnable()
    {
        float score = PlayerPrefs.GetFloat("scoresock");
        float highScore;
        if (PlayerPrefs.HasKey("highScoresock"))
        {
            highScore = PlayerPrefs.GetFloat("highScoresock");
        }
        else
        {
            highScore = 0;
        }
        if (score > highScore)
        {
            PlayerPrefs.SetFloat("highScoresock", score);
            highScoreText.text = score.ToString();
  
        }
        else
        {
   
            highScoreText.text = highScore.ToString();
        }
    }



    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("il ya plus d'instance d'invent dans la scène");
            return;
        }
        instance = this;
    }


    public void AddCoins(int count)
    {
        coinsCount += count;
        CoinsCountText.text = coinsCount.ToString();
    }

    public void Addeath(int count)
    {
        deathCount += count;
        
        score = coinsCount * 100 / deathCount;
        PlayerPrefs.SetFloat("scoresock", score);
        scoreText.text = coinsCount.ToString();
    }


    public void openPop()
    {
        fpop.SetActive(true);
        backgMusic.SetActive(false);
    }

    public void del()
    {
        deathCount = 0;
        coinsCount = 0;
        CoinsCountText.text = coinsCount.ToString();
    }


}
