using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
    public GameObject pop;
    public GameObject backgMusic;

    // Start is called before the first frame update
    void Start()
    {
        pop = GameObject.FindGameObjectWithTag("pop");
        backgMusic = GameObject.FindGameObjectWithTag("backg");
        backgMusic.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closer()
    {
       
        pop.SetActive(false);
        backgMusic.SetActive(true);


    }
}
