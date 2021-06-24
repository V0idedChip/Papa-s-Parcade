﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerControlerScript : MonoBehaviour
{
    public int MovementSpeed;
    

    private Rigidbody2D rb;

    Vector2 movement;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MovementSpeed * Time.fixedDeltaTime);
    }





}
