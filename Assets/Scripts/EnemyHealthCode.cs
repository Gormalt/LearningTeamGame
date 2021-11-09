using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthCode : MonoBehaviour
{

    public int maxEnemyHealth = 2;
    public int currentHealth;
    public int damageTaken = 1;


    void Start()
    {
        currentHealth = maxEnemyHealth;
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "PlayerWeapon")
        {
            currentHealth -= damageTaken;
            Debug.Log("enemy is hit");
        }
    }

}