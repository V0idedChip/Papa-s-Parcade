using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIM : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Vector3 curMousePos = Input.mousePosition;
        curMousePos.z = Camera.main.nearClipPlane;
        curMousePos = Camera.main.ScreenToWorldPoint(curMousePos);
        curMousePos.z = -8;
        Debug.Log("Mouse pos at " + curMousePos);
        this.transform.position = curMousePos;
    }
}
