using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
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
        var targetPos = new Vector2(transform.position.y, target.position.x);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


    }


}
