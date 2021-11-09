using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;
    public int damageTaken = 1;
    public bool invincible = false;
    public int invincibleTimer = 1;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    //when you collide with something tagged as enemy
    //and you're not invincible, take damage and stay invincible
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
 
        if (invincible == false & collisionInfo.collider.tag == "Enemy")
        {
            currentHealth -= damageTaken;

            healthBar.SetHealth(currentHealth);

            //I had never used invoke before
            //while this works, i don't know if it could mess something
            //up in the future
            invincible = true;
            Invoke("undoInvincibility", invincibleTimer);
        }
    }

    private void undoInvincibility()
    {
        invincible = false;
    }

}