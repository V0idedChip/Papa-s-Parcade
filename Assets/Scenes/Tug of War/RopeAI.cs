using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class RopeAI : MonoBehaviour
{

    public int speed;
    private Transform target;
    private Rigidbody2D rb;
    public float stoppingDistance;
    
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

}
