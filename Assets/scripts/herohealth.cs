using UnityEngine;
using System.Collections;

public class herohealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;


    public float invincibilityflashdelay = 0.2f;
    public float invincibilitytimehit = 2f;
    public bool isInvincible = false;

    public healthbar healthBar;

    public SpriteRenderer graphics;

    public static herohealth instance;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("il ya plus d'instance de King health dans la scène");
            return;
        }
        instance = this;
    }
    void Start()
    {
        healthBar = GameObject.FindGameObjectWithTag("Life").GetComponent<healthbar>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(currentHealth);
    }

    void Update()
    {
        maxHealth = currentHealth;
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(60);
        }
    }

    public void HealPlayer(int amount)
    {

        if ((currentHealth + amount) > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += amount;
        }

        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
            //bech nthabtou alli l king dima 7ay

            if (currentHealth <= 0)
            {
                Die();
                return;
            }

            isInvincible = true;
            StartCoroutine(invincibilityflash());
            StartCoroutine(handleinvincibilitydelay());
        }
    }
    public void Die()
    {
        Debug.Log("le joueur est éliminé");
        movementplayer.instance.enabled = false;
        movementplayer.instance.animator.SetTrigger("die");
        movementplayer.instance.rb.bodyType = RigidbodyType2D.Kinematic;
        movementplayer.instance.playerCollider.enabled = false;
        gameOver.instance.OnPlayerDeath();
        //neblokiw l mouvement te3 lking

    }

    public void Respawn()
    {
        movementplayer.instance.enabled = true;
        movementplayer.instance.animator.SetTrigger("Respawn");
        movementplayer.instance.rb.bodyType = RigidbodyType2D.Dynamic;
        movementplayer.instance.playerCollider.enabled = true;
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);

    }

    public IEnumerator invincibilityflash()
    {
        while (isInvincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(invincibilityflashdelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(invincibilityflashdelay);
        }
    }

    // yestana 9bal mayetnaha el invinciblity 
    public IEnumerator handleinvincibilitydelay()
    {
        yield return new WaitForSeconds(invincibilitytimehit);
        isInvincible = false;
    }
}
