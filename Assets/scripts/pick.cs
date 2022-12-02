using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundManager.playSound("socks");

            invent.instance.AddCoins(1);
            Destroy(gameObject);
        }
    }
}
