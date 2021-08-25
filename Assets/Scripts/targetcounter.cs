using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetcounter : MonoBehaviour
{

    public target[] targets;
    public int targetno = 0;
    private target currenttarget;
    private Finish fin;
    public int laps;
    private int curlaps = 0;

    void Start()
    {
        currenttarget = targets[targetno];

    }
    // Update is called once per frame
    void Update()
    {
        if (currenttarget.reached)
        {
            currenttarget.reached = false;
            targetno++;
            if (targetno >= targets.Length)
            {
                targetno = 0;
                curlaps++;
                if (LapCheck())
                {
                    //game end 
                    Debug.Log("Fin");
                    TheGameManager.instance.Win();
                }




            }
            currenttarget = targets[targetno];
        }
    }

    private bool LapCheck()
    {
        if (curlaps >= laps)
        {
            return true;

        }
        return false;

    }


}
