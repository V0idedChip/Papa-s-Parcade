using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarioController : MonoBehaviour
{
    float xInput, yInput;
    private Rigidbody2D rb;
    public Animator animator;
    public float jumpVelocity = 1000f;
    private Vector2 moveVelocity;
    public float speed;
    
    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
    }

     
    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * speed, yInput * speed, 0);
        PlatformerMove();
        
    }
    void Update()
    {
        
       
        if (Input.GetKeyDown(KeyCode.W))
        {

            Jump(); 
            
        }


        animator.SetFloat("Horizontal", moveVelocity.x);
        animator.SetFloat("Vertical", moveVelocity.y);
        animator.SetFloat("Speed", moveVelocity.sqrMagnitude);


    }

  
    void Jump()
    {
        rb.AddForce(Vector2.up * jumpVelocity);
        Debug.Log("KEY Pressed");
    }

   void PlatformerMove()
    {
        rb.velocity = new Vector2(speed * xInput, rb.velocity.y);
    }



    

}
