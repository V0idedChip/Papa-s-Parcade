using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Fin;
    public bool reached = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("HIT");

        if (collision.gameObject.tag == "Player")
        {
            reached = true;
            Time.timeScale = 0f;

        }

        
    }
}
