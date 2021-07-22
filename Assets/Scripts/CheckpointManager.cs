using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Checkpoint[] checkpoints;
    public int checkpointno = 0;
    private Checkpoint currentCheckpoint;    
    private Finish fin;

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
            }
            currentCheckpoint = checkpoints[checkpointno];
        }
    }

   

    
}
