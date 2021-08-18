using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarioController : MonoBehaviour
{
    private PLayerControlerScript pLayer;
    private Rigidbody2D rb;

    private void Awake()
    {
        pLayer = gameObject.GetComponent<PLayerControlerScript>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 1000f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }



}
