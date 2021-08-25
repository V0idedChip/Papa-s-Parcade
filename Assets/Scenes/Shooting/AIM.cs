using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIM : MonoBehaviour
{
private targetcounterarray ta;
 private int _score = 0;
 public int scorecounter;   

private void Start() {
    ta = GetComponent<targetcounterarray>();
    scorecounter = _score; 
}
         
            
    // Update is called once per frame
    void Update()
    {
        Vector3 curMousePos = Input.mousePosition;
        curMousePos.z = Camera.main.nearClipPlane;
        curMousePos = Camera.main.ScreenToWorldPoint(curMousePos);
        curMousePos.z = -8;
        this.transform.position = curMousePos;
        if(scorecounter >= 6)
        {
                TheGameManager.instance.Win();
        }
    }
public void Score()
{
_score++;
}
}
