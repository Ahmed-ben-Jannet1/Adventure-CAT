using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{
    public bool isPlayerPresentByDefault = false;
    public static CurrentSceneManager instance;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("il ya plus d'instance de CurrentSceneManager dans la scène");
            return;
        }
        instance = this;
    }
}
