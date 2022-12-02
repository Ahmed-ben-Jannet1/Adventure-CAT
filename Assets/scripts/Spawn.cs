using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;


public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
    }
}
