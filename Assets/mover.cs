﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
    public float maxspeed = 10f;
    
    public float speed = 2f;


    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent < Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    void FixedUpdate() {



        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right*speed*h);

        if (rb2d.velocity.x > maxspeed)
        {
            rb2d.velocity = new Vector2(maxspeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxspeed)
        {
            rb2d.velocity = new Vector2(-maxspeed, rb2d.velocity.y);
        }
    
    }
}
