using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("HIT");

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
