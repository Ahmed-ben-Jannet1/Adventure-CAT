using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public GameObject backgMusic;
    public GameObject pop;
    public GameObject setting;
    public GameObject levels;
    public GameObject bloc;
    public GameObject sounding;
    private static bool musicon;


    void Start()
    {
        musicon = true;
    }

    public void Play()
    { SceneManager.LoadScene("level"); }
    public void Exit()
    { Application.Quit(); }
    public void Level1()
    { SceneManager.LoadScene("level"); }
    public void Level2()
    { SceneManager.LoadScene("Main"); }
    public void help()
    {   
        pop.SetActive(true);
     }

    public void settings()
    {

        setting.SetActive(true);
        
    }
    public void Levels()
    {
        setting.SetActive(false);
        levels.SetActive(true);
        
    }
    public void Name()
    {
        bloc.SetActive(true);
    }

    public void Sound()
    {
        sounding.SetActive(true);
        setting.SetActive(false);
    }

  public void muting()
    {
        if (musicon == true )
        {
            backgMusic.SetActive(false);
            musicon = false;
        } else
        {
            backgMusic.SetActive(true);
            musicon = true;
        }
    }

}
