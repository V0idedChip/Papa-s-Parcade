using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostcounter : MonoBehaviour
{
   
    public ghost[] ghosts;
    public int ghostno = 0;
    private ghost currentghost;    
    private Finish fin;
    public int laps;
    private int curlaps=0;

    void Start()
    {
        currentghost = ghosts[ghostno];
        
    }
    // Update is called once per frame
    void Update()
    {
        if (currentghost.reached)
        {
            currentghost.reached = false;
            ghostno++;
            if (ghostno >= ghosts.Length)
            {
                ghostno = 0;
                curlaps++;
                if (LapCheck())
                {
                    //game end 
                    Debug.Log("Fin");
                    TheGameManager.instance.Win();
                }
                

                
                
            }
            currentghost = ghosts[ghostno];
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
