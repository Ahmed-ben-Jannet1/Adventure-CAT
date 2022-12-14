using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Transform playerSpawn;
    private Animator fadeSystem;

    private void Awake()
    {
        playerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            invent.instance.Addeath(1);
            StartCoroutine(ReplacePlayer(collision));
        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision)
    {
        SoundManager.playSound("fail");    
        fadeSystem.SetTrigger("fading");
        yield return new WaitForSeconds(1f);
        collision.transform.position = playerSpawn.position;
    }
}
