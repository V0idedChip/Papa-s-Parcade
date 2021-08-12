using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AIpaddle : MonoBehaviour
{
   
    public int speed;
    private Transform target;
    private Rigidbody2D rb;

    void Start()
    {
       
        target = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var targetPos = new Vector2(transform.position.x, target.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        
    }

}

   


