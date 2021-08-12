using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarioController : MonoBehaviour
{
    public float moveSpeed;
    public int health;
    public Animator animator;
    
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        Jump();
    

        
        
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }

    

    
}
