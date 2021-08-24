using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerControlerScript : MonoBehaviour
{
    public int MovementSpeed;
    public AudioClip SFX;
    private AudioSource audioSource;

    private Rigidbody2D rb;

    Vector2 movement;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = gameObject.GetComponent<AudioSource>();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {

            audioSource.clip = SFX;

            audioSource.Play();

        }
    }



}
