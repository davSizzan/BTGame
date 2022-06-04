﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("Movement Stuff")]
    public float moveSpeed;
    public Vector2 directionToMove;

   
    public Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
/*    void Update()
    {
        lifetimeSeconds -= Time.deltaTime;
        if(lifetimeSeconds<=0)
        {
            Destroy(this.gameObject);
        }
    }*/

    public void Launch(Vector2 initialVel)
    {
        myRigidbody.velocity = initialVel * moveSpeed;
    }

/*    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        
    }*/
}