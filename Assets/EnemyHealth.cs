using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthCode : MonoBehaviour
{

    public int maxEnemyHealth = 2;
    public int currentHealth;
    public int damageTaken = 1;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxEnemyHealth;
        healthBar.SetMaxHealth(maxEnemyHealth);
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    //when you collide with something tagged as enemy
    //and you're not invincible, take damage and stay invincible
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.name == "Bullet")
        {
            currentHealth -= damageTaken;

            healthBar.SetHealth(currentHealth);


        }
    }

}