using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongLose : MonoBehaviour
{
    BoxCollider2D box;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TheGameManager.instance.Lose();
        Debug.Log("lose");
    }
}
