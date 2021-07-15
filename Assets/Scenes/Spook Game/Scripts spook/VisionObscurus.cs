using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionObscurus : MonoBehaviour
{
    public Vector3 mousePos;
    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = mousePos;
        
    }
}
