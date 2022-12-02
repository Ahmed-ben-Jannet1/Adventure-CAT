using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadNewScene : MonoBehaviour
{
    public string SceneName;
    public Animator fadeSystem;
    


    private void Awake()
    {
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {


            StartCoroutine(loadNextScene());
        }

    }


    public IEnumerator loadNextScene()
    {
        SoundManager.playSound("done");
        fadeSystem.SetTrigger("fading");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneName);
    }
}
