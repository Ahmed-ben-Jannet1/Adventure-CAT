using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class finalPop : MonoBehaviour
{
    public GameObject pop;
    public Animator fadeSystem;
    



    private void Awake()
    {
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(final());
        }

    }


    public IEnumerator final()
    {
        SoundManager.playSound("done");
        invent.instance.openPop();
        
        yield return new WaitForSeconds(1f);


    }
}
