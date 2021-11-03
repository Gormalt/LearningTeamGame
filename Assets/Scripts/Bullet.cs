using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    //once the bullet is created, make it move in the direction the player is facing
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //once there is a collision, delete the bullet object
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if(hitInfo.name != "Player")
        {
            Destroy(gameObject);
            Debug.Log(hitInfo.name);
        }

    }

}
