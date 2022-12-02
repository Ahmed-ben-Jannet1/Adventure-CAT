using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video : MonoBehaviour
{
    private float startWait = 12f;
    public GameObject videoo;
    public GameObject musicaaa;
    public GameObject popa;


    void Start()
    {
        

        Invoke("Initialize", startWait);
    }

    void Initialize()
    {
        // Your code
        videoo.SetActive(false);
        musicaaa.SetActive(true);
        popa.SetActive(true);


    }
}
