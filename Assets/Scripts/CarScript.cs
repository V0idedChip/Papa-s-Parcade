using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    public float speed;
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
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        animator.SetFloat("Horizontal", moveVelocity.x);
        animator.SetFloat("Vertical", moveVelocity.y);
        animator.SetFloat("Speed", moveVelocity.sqrMagnitude);
        animator.SetTrigger("health");
    }

   

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");

        if (collision.gameObject.tag == "Death")
        {
            animator.Play("BOOM");
            Destroy(gameObject,0.6f);
            Time.timeScale = 0.6f;
        }
    }

}