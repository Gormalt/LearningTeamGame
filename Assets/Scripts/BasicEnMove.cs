using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnMove : MonoBehaviour
{
    private float direction = -1f;
    private float enemySpeed = 1f;
    private Rigidbody2D rb;
    private float leftBound = -1;
    private float rightBound = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //enemy moves in direction it's facing
        rb.velocity = new Vector2(direction * enemySpeed, 0);

        if (rb.transform.position.x < leftBound)
        {
            //once enemy hits left bound, give it a little push right and change direction
            rb.AddForce(new Vector2(100f, 0));
            direction *= -1;
        }

        if (rb.transform.position.x > rightBound)
        {
            //once enemy hits right bound, give it a little push left and change direction
            rb.AddForce(new Vector2(-100f, 0));
            direction *= -1;
        }
    }

    
    
}
