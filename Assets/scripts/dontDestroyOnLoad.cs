using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class dontDestroyOnLoad : MonoBehaviour
{
    public GameObject[] objects;

    public static dontDestroyOnLoad instance;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("il ya plus d'instance de dont destroy dans la scène");
            return;
        }
        instance = this;

   

    }


    public void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        

        if (sceneName == "menu")
        {
            foreach (var element in objects)
            {
                Destroy(element);
            }

        }
        else if (sceneName == "main")
        {
            foreach (var element in objects)
            {
                Destroy(element);
            }
        }

        else
        {
            foreach (var element in objects)
            {
                DontDestroyOnLoad(element);
            }

        }
    }
    

    public void RemoveFromDontDestroyOnLoad()
    {
        foreach (var element in objects)
        {
            SceneManager.MoveGameObjectToScene(element, SceneManager.GetActiveScene());
             
        }
    }
}
