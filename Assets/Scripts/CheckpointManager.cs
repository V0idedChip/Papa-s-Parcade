using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public Checkpoint[] checkpoints;
    public int checkpointno = 0;
    private Checkpoint currentCheckpoint;    
    private Finish fin;
    public int laps;
    private int curlaps=0;

    void Start()
    {
        currentCheckpoint = checkpoints[checkpointno];
        
    }
    // Update is called once per frame
    void Update()
    {
        if (currentCheckpoint.reached)
        {
            currentCheckpoint.reached = false;
            checkpointno++;
            if (checkpointno >= checkpoints.Length)
            {
                checkpointno = 0;
                curlaps++;
                if (LapCheck())
                {
                    //game end 
                    Debug.Log("Fin");
                    TheGameManager.instance.Win();
                }
                

                
                
            }
            currentCheckpoint = checkpoints[checkpointno];
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
