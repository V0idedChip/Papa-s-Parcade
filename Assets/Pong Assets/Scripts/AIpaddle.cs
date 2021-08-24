using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AIpaddle : MonoBehaviour
{
   
    public int speed;
    private Transform target;
    private Rigidbody2D rb;
    public AudioClip SFX;
    private AudioSource audioSource;
    private BoxCollider2D box;

    void Start()
    {
       
        target = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        var targetPos = new Vector2(transform.position.x, target.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        
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

   


