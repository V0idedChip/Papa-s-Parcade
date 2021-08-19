using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class AIpaddle1 : MonoBehaviour
{
   
    public int speed;
    private Transform target;
    private Rigidbody2D rb;
    public Vector2 startingPosition = new Vector2(5f,0.0f);

    private GameObject ball;
    private Vector2 ballPos;

    void Start()
    {

        transform.localPosition = (Vector3)startingPosition;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (!ball)
            ball = GameObject.FindGameObjectWithTag("ball");

        
    }

}

   


