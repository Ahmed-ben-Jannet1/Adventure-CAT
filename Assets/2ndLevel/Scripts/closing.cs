using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closing : MonoBehaviour
{
    public GameObject pop;
    public GameObject backgMusic;


    public void closer()
    {

        pop.SetActive(false);
        backgMusic.SetActive(true);


    }
}
