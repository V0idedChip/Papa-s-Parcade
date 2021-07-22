using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{



    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT");

        if (collision.gameObject.tag == "Player")
        {
            ;
        }
    }
}
