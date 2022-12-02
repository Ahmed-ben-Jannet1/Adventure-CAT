using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int damageoncollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SoundManager.playSound("hit");
            herohealth herohealth = collision.transform.GetComponent<herohealth>();
            herohealth.TakeDamage(damageoncollision);
        }
    }
}
