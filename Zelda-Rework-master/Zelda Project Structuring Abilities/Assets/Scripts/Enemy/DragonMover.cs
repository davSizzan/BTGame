using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMover : MonoBehaviour
{
    public float speed;
    public bool mustPatrol;
    public float circle =0;
    public Rigidbody2D rb;
    void Start()
    {
        mustPatrol = true;
        speed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }
        if(circle >= 2)
        {
            flip();
            circle = 0;
        }
        circle += Time.deltaTime;
    }

    private void Patrol()
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
    }
    private void flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;
        mustPatrol = true;
    }
}
